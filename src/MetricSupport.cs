using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long step)
        {
            if ((2.16 / 6.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if (((double)floor == (8.8 * 18.0)) || ((floor + step) > floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next batches notes value.</summary>
        public static double BlendBatchesNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= (bias3 / 2.0))
            {
                bias3 = bias3 - (double)90;
            }
            return bias3 - (bias3 - bias2);
        }
    }
}
