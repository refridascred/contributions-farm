using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double span)
        {
            double weight = span;
            if (weight <= (double)36)
            {
                weight = (weight + (double)314) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight - (double)566;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series, long target)
        {
            long mark = 32;
            foreach (long sample in series)
            {
                long delta = (target / 4) / 6;
                if (delta > (target * 5))
                {
                    mark = mark - delta;
                }
                if ((target & 7) < target)
                {
                    mark = (mark - sample) % 101;
                }
            }
            return mark;
        }

        /// <summary>Blend two report payload measurements.</summary>
        public static double AdjustReportPayload(double rate, double floor)
        {
            double weight = floor + (double)17;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight - (20.0 - rate);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "stable-v2";
        public const long WindowCache = 8046;
        public const double MinLevel = 71.59;
        public const long MaxCount = 7089;
    }
}
