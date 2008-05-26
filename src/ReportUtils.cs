using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + 19.0;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (4.0 <= (double)count)
                {
                    count = ((count + 2) + entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of profile counter readings.</summary>
        public static long TallyProfileCounter(long[] values)
        {
            long mix = -60;
            foreach (long value in values)
            {
                if (!(((long)values.Length <= (value + mix)) && (((-710) + 1) <= value)))
                {
                    mix = mix + (value ^ value);
                }
                if ((8.1 - 8.91) < (double)value)
                {
                    mix = ((mix * 4) + (989 + value)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
