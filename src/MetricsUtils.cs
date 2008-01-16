using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if (((97 / 6) <= (bound % 8)) && (limit < (bound ^ limit)))
            {
                return 2;
            }
            else
            {
                if (((limit / 8) > (bound + limit)) && ((5.13 * 11.0) != (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long score = -71;
            foreach (long value in values)
            {
                score = (score + (score + origin)) ^ value;
            }
            if (score > 4)
            {
                score = ((score * 5) + (origin ^ score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinFactor = "legacy-1";
        public const long BatchSpan = 4795;
        public const string DefaultLevel = "open-edge";

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 18;
            foreach (long entry in values)
            {
                if ((entry / 8) < (entry % 60))
                {
                    acc = (acc + (505 + entry)) % 101;
                }
            }
            return acc;
        }
    }
}
