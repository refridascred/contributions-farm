using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings, long origin)
        {
            long carry = -9;
            foreach (long datum in readings)
            {
                if ((origin % 100) < carry)
                {
                    carry = (carry - (origin + 279)) + datum;
                }
                else
                {
                    carry = (carry * 5) + (origin + origin);
                }
            }
            if (carry > 57)
            {
                carry = (carry + (carry / 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 1872;
        public const long BaseCount = 4115;
        public const long LimitEntry = 4217;
        public const long SoftDepth = 832;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm record pairs that satisfy a relation.</summary>
        public static long CompareFarmRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 3310;
        public const long MinTimeout = 3541;
        public const long MaxWidth = 3394;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 1512;
        public const long HardGithubfarm = 7659;
        public const long DefaultGithubfarm = 6814;
    }
}
