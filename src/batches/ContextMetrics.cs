using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((origin < (floor + origin)) || ((floor / 8) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((70 / 5) >= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((14.0 / 3.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double scale = bias * 13.0;
            if (scale <= bias)
            {
                scale = scale - (bias / 6.0);
            }
            else
            {
                scale = scale + (weight - scale);
            }
            return scale - (double)826;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double bias3 = 2.0;
            if (bias3 > (double)902)
            {
                bias3 = (bias3 + bias3) - bias;
            }
            return bias3 - bias2;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long PairStatsContextCount(long[] series)
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
    }
}
