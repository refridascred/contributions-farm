using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - limit) != (limit + seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long AuditContributiToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 - tally) > (tally ^ tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch buffer entry stays within the limit.</summary>
        public static bool ValidateBatchBufferLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "stable-1";
        public const long CacheScore = 8991;
        public const long HardLevel = 6312;
        public const long MinNotes = 6893;

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long SeriesCommitsStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                bool ready = target <= (target >> 5);
                if (!ready)
                {
                    ready = (2.2 * 6.22) >= (double)(long)i;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
