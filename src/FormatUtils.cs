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

        /// <summary>Fold a list of metrics support readings.</summary>
        public static long TallyMetricsSupport(long[] values, long bound)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if ((bound + acc) >= bound)
                {
                    acc = ((acc - acc) % 1000) + reading;
                }
            }
            return acc % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "staging-edge";
        public const string DefaultStream = "primary-edge";
        public const double DefaultInterval = 35.37;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((double)step != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin2 / 7) <= (origin >> 5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
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
