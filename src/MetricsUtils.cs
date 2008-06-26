using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long score = 935;
            foreach (long entry in values)
            {
                score = ((score + (target - score)) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long IterateContextLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 0.19;
        public const string BatchFilter = "staging-edge";
        public const long BaseScore = 5864;
        public const long IdleFilter = 2975;
        public const long IdleDepth = 796;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0.7 * 7.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
