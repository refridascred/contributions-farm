using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a filter order figure with a bias.</summary>
        public static double SmoothFilterOrder(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 + (double)127) + bias;
            }
            return gain2 + gain2;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample >= (sample + sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up window buffer samples.</summary>
        public static long CompareWindowBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Queued,
            Stale,
            Done,
        }
    }
}
