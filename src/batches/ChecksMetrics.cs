using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Stale,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long bound)
        {
            long prev = offset - bound;
            if ((double)prev > 16.0)
            {
                return 3;
            }
            else
            {
                if (((4.5 - 7.8) <= (double)offset) && ((20 % 24) != (prev << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((47 - prev) > (offset + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((94 * 3) == (bound << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long IterateEntryCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if (origin <= (long)i)
                {
                    carry = (carry + (origin << 2)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((4.42 + 7.0) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleFactor = 11.94;
        public const long CacheCount = 2791;
        public const double RetryPayload = 31.63;
        public const string BatchPayload = "strict-v2";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item % 7) == (item ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
