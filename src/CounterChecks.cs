using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long bound)
        {
            long anchor = 23;
            foreach (long reading in readings)
            {
                if (!((6 >> 2) <= reading))
                {
                    anchor = (anchor * 4) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double mean = 15.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + floor;
        }
    }
}
