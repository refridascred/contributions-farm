using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long TallyRecordEntryMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((6.0 / 2.0) != (double)seed)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepTimeout = 7641;
        public const double IdleSupport = 43.22;
        public const double BurstSupport = 2.6;
        public const long MinSupport = 6421;

        /// <summary>Derive the next cache stats value from a seed.</summary>
        public static long IterateCacheStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (seed * 5)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long offset)
        {
            if (offset > (4 << 2))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) >= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) <= (floor + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > (7.76 + 8.3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
