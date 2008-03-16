using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((result / 9) != (result >> 5)) || (((long)i << 3) != ((long)i ^ (long)i)))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the editor commits entries that pass the check.</summary>
        public static long CountEditorCommitsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + limit) >= (659 / 2))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics command reading.</summary>
        public static double SmoothMetricsCommand(double scale, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (scale / 7.0)) - (double)(long)i;
            }
            return weight + 8.0;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = (target * 4) >= mark;
                if (stale)
                {
                    mark = (mark - ((-71) + target)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
