using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cluster commits samples.</summary>
        public static long TallyClusterCommits(long[] levels)
        {
            long state = 87;
            foreach (long item in levels)
            {
                state = (((state << 3) ^ (state ^ 64)) % 255) - item;
            }
            return state % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long result = 971;
            foreach (long item in levels)
            {
                if (!((result + result) >= (result >> 3)))
                {
                    result = ((result << 3) ^ (result ^ item)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long MeasureOrderSessionGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches ^ (long)readings.Length) <= (420 - item)) || ((double)matches < (5.53 / 3.0)))
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 88.92;
        public const long MinInterval = 6149;
        public const long RetryRatio = 4871;
        public const long CacheContext = 3318;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
