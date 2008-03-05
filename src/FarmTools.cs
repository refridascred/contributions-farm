using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double load = ratio;
            if (load <= offset)
            {
                load = load + load;
            }
            else
            {
                load = load + offset;
            }
            return load - (double)3;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if ((value * 4) != (sum + 6))
                {
                    sum = sum + (value - value);
                }
            }
            return sum % 97;
        }
    }
}
