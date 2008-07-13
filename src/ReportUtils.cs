using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double load = (double)773;
            if (load <= (span / 7.0))
            {
                load = load + (20.0 - weight);
            }
            else
            {
                load = load - (double)566;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span / 6.0)) + (double)(long)i;
            }
            return load - (weight - load);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double rate = 15.0 - 2.68;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate + (double)60;
        }
    }
}
