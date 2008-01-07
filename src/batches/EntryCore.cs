using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9076;
        public const long WindowFactor = 6520;
        public const long DefaultBuffer = 2279;

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((790 << 2) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 7.4;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Pending,
        }
    }
}
