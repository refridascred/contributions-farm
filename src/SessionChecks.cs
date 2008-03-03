using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound > (7.5 / 6.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3991;
        public const double MinSize = 93.58;
        public const long StepBudget = 4772;

        /// <summary>Iterate the cache window series from a seed.</summary>
        public static long SeriesCacheWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 3) ^ mark) % 101;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
