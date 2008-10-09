using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double scale = 4.29 + 4.45;
            if (scale <= (double)110)
            {
                scale = ((scale - (double)36) - rate) + offset;
            }
            else
            {
                scale = scale + (double)4;
            }
            return scale + (8.24 - 11.0);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next counter metric value.</summary>
        public static double BlendCounterMetric(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (span - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double gain = offset;
            if (gain >= weight)
            {
                gain = gain + 9.1;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
