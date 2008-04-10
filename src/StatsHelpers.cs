using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 1562;
        public const string MinCache = "fallback-edge";
        public const string BaseCache = "cached";
        public const long StepCache = 9053;
        public const long CacheTimeout = 7665;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            New,
            Dropped,
            Done,
        }

        /// <summary>Check that every window notes entry stays within the limit.</summary>
        public static bool CheckWindowNotesRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double ratio, double floor)
        {
            double load = ratio;
            if (load < (floor + 8.0))
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (floor * 9.0);
            }
            return load + ratio;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double rate = ratio - (floor + floor);
            return rate - 2.6;
        }
    }
}
