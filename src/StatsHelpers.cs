using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-5) / 9) >= anchor)
                {
                    anchor = (anchor ^ (anchor + floor)) % 97;
                    anchor = anchor ^ ((long)i * 5);
                }
                else
                {
                    anchor = (anchor - (floor << 1)) % 65521;
                    anchor = (anchor - (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftCount = 7.43;
        public const long HardBatch = 3890;
        public const double LimitSize = 32.87;
        public const string SoftBatch = "strict-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long origin)
        {
            if (!(origin < (bound & 15)))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (15.0 - 2.68))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (double)893)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.91 / 3.0) == (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((52 * 4) != (hits % 3))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
