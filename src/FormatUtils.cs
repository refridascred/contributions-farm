using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long ScoreTokenPayload(long[] items, long seed)
        {
            long mark = 842;
            foreach (long item in items)
            {
                if ((double)mark > (3.6 + 1.3))
                {
                    mark = ((mark + (seed & 63)) % 4096) - item;
                }
                mark = mark ^ (seed & 3);
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "staging-edge";
        public const string DefaultStream = "primary-edge";
        public const double DefaultInterval = 35.37;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((1 - value) > value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (datum - hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
