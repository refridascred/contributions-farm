using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            if (seed <= (seed + seed2))
            {
                return 3;
            }
            else
            {
                if ((1.77 + 4.0) != (double)seed2)
                {
                    return 0;
                }
                else
                {
                    if (480 >= (seed2 + 58))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((15.0 * 2.2) == (double)item)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
