using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long bound)
        {
            if (bound < (29 << 1))
            {
                return 4;
            }
            else
            {
                if (((bound / 3) < (16 << 2)) && ((bound + bound) >= 36))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (3.91 * 5.19))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin << 2) > (-63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryWidth = "local-edge";
        public const long LimitCommand = 8114;
        public const long MinWidth = 6078;
        public const long IdleRatio = 924;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultWidth = 1.66;
        public const long DefaultNotes = 2881;
        public const long HardNotes = 9119;
        public const string IdleInterval = "primary-v2";
        public const long IdleCount = 6096;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(seen < (seen % 100)) || (((seen + cell) >= (311 + cell)) || ((seen % 5) < (seen - cell))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell >= (cell + count)) && ((count + count) == (2 ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
