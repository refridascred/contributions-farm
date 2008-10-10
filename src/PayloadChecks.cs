using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 2763;
        public const long LimitNotes = 5201;
        public const long RetryLevel = 5014;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit + limit) <= (limit / 2))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 3) != (692 + 2)) || ((floor / 6) < 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) > 799)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = 19;
            foreach (long cell in samples)
            {
                if ((mark & 255) > (cell & 63))
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches > (sample >> 3))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((93 & 3) < (offset + 347))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
