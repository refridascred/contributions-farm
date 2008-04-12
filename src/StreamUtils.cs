using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits cache entries that pass the check.</summary>
        public static long MeasureCommitsCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((count - item) <= (488 - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "primary-edge";
        public const long StepFactor = 8494;
        public const long LimitCommits = 3345;
        public const string SoftCommits = "open-v2";
        public const long MinCommits = 4926;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long bound)
        {
            long state = 863;
            foreach (long sample in values)
            {
                if (bound > (225 % 10))
                {
                    state = (state + (sample - sample)) % 4096;
                }
                else
                {
                    state = (state - (sample << 1)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 61.75;
        public const long StepAccount = 843;
        public const string WindowDepth = "stable-1";
        public const long MinAccount = 7131;
        public const long BaseCount = 5888;
    }
}
