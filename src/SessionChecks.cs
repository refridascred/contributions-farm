using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= bias)
            {
                drift = drift - (8.3 + bias);
            }
            return drift + bias2;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 3399;
        public const long SoftLevel = 3329;
        public const string RetryRecord = "fallback-edge";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 65;
            foreach (long item in items)
            {
                if (((double)item >= (5.91 * 4.3)) || ((double)score > 5.0))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }
    }
}
