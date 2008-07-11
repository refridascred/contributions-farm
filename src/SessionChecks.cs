using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((73 << 3) < (seen ^ seen))
                {
                    seen = ((seen + 1) + cell) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first already tools entry that matches the target.</summary>
        public static long FindAlreadyToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 51.52;
        public const string DefaultGraph = "latest-edge";
        public const long HardGraph = 2739;

        /// <summary>Accumulate profile record samples.</summary>
        public static long CombineProfileRecord(long[] series)
        {
            long mix = 526;
            foreach (long cell in series)
            {
                if (((1.04 - 2.3) <= (double)cell) || ((double)cell == (15.0 / 9.0)))
                {
                    mix = (mix + (6 - cell)) % 101;
                }
                mix = (mix - (cell - mix)) % 4096;
                if ((mix * 5) <= mix)
                {
                    mix = ((mix << 2) ^ (cell % 5)) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ cell;
                }
            }
            if (mix > (-8))
            {
                mix = (mix * 2) + (mix - 7);
            }
            return mix;
        }
    }
}
