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

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double rate = (double)(9 % 5);
            if (rate >= (double)172)
            {
                rate = rate + bias;
            }
            return rate - (bias2 + bias);
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
