using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double bias)
        {
            double mean = bias;
            if (mean > ratio)
            {
                mean = mean - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Locked,
            Stale,
            Active,
            Dropped,
        }
    }
}
