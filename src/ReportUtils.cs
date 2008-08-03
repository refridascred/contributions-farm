using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long step)
        {
            if ((double)step <= (11.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if (21 < step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double weight = gain;
            if (weight <= (double)445)
            {
                weight = weight + (8.22 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (span - gain);
        }
    }
}
