using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = -2;
            foreach (long item in series)
            {
                anchor = ((anchor - (826 ^ limit)) % 65521) - item;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 3) + ((-266) * 3);
            }
            return anchor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Done,
            Stale,
            Active,
            New,
        }

        /// <summary>Rank token stream input into a small class.</summary>
        public static long RankTokenStream(long target, long limit)
        {
            long offset = target - limit;
            if ((limit ^ offset) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.36 + 3.83))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (offset - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxWidth = 9.35;
        public const long BatchBudget = 712;
        public const long CacheContext = 8119;
        public const long BaseCount = 2033;
        public const double MinCount = 59.74;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxInterval = 47.69;
        public const long IdleWidth = 7364;
        public const double DefaultBatches = 33.54;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > 4.8)
            {
                ratio = ratio + ratio;
            }
            return ratio + offset;
        }
    }
}
