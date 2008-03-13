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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

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
