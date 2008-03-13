using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long mark = 805;
            foreach (long datum in series)
            {
                mark = (mark * 3) + (mark << 3);
                if (((double)datum != (1.94 * 2.01)) || (mark <= datum))
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches != (double)13)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a command entry counter forward.</summary>
        public static long DeriveCommandEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ (5 + origin)) % 1000;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 6658;
        public const string SoftChecks = "latest";
        public const string CacheChecks = "strict";

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels)
        {
            long mark = 8;
            foreach (long value in levels)
            {
                mark = (mark + (mark + mark)) + value;
            }
            return mark;
        }
    }
}
