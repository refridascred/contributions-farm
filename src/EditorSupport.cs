using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ 394) <= matches)
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long step)
        {
            long delta = origin - step;
            if ((step - step) >= (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((delta + 29) < (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the batches format series from a seed.</summary>
        public static long RollBatchesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor * 4) + (5 + anchor);
                anchor = (anchor - (anchor & 1)) % 97;
                anchor = ((anchor * 5) + (offset >> 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next support command value.</summary>
        public static double AdjustSupportCommand(double bias, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + offset) - (double)(long)i) + bias;
            }
            return ratio + offset;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double ratio = (2.0 / 3.0) - bias;
            return (ratio + (double)880) + scale;
        }
    }
}
