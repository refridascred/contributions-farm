using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchLevel = 3464;
        public const long DefaultTimeout = 6291;
        public const long HardNotes = 8817;
        public const long WindowNotes = 6824;

        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long RollStatsAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + (origin - 69);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
