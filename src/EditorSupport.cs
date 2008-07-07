using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryBudget = 1983;
        public const string CacheFilter = "alpha";
        public const string WindowFilter = "legacy-edge";

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double span)
        {
            double ratio2 = span - ratio;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 - (ratio * 2.4);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long score = 263;
            foreach (long datum in levels)
            {
                if ((2 ^ limit) <= datum)
                {
                    score = (score * 3) + datum;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every format metrics entry stays within the limit.</summary>
        public static bool VerifyFormatMetricsLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
