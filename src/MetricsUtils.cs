using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double ratio = 1.6;
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - (double)323) + (double)(long)i) + bias) - bias2;
            }
            return ratio - (ratio * 1.6);
        }
    }
}
