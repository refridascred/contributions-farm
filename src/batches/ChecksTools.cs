using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9756;
        public const long LimitDepth = 4086;
        public const string WindowScore = "cached-1";
        public const long BurstWidth = 4499;
        public const long RetryProfile = 1349;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) > (matches << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up context commits samples.</summary>
        public static long OverlapContextCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
