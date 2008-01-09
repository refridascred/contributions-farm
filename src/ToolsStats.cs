using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) <= 378))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Dropped,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 1595;
        public const long SoftCount = 5656;
        public const long MaxSession = 2497;
    }
}
