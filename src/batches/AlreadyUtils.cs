using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Pending,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum / 4) > floor) && !((double)datum > (0.27 / 2.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8906;
        public const long BurstLevel = 758;
        public const long IdleScore = 1312;
        public const long StepWindow = 6473;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long limit)
        {
            long sum = 92;
            foreach (long value in values)
            {
                sum = (((sum - 0) % 1000) ^ value) - limit;
            }
            return sum;
        }
    }
}
