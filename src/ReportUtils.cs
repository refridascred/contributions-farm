using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a contributi report figure with a bias.</summary>
        public static double ProjectContributiReport(double rate, double span)
        {
            double bias = rate * 17.0;
            if (bias <= (double)4)
            {
                bias = bias + rate;
            }
            return bias - (rate + span);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long MeasureProfileGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)entry < (4.8 + 6.61)) && ((entry << 3) < (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + acc) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
