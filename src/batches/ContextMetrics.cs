using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a contributi metrics reading by value.</summary>
        public static long LocateContributiMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double drift = 9.91;
            if (drift >= (double)828)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + 4.03;
        }
    }
}
