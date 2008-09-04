using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel schema reading.</summary>
        public static double SmoothChannelSchema(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate * 2.57))
            {
                rate = (rate + (span / 2.0)) - scale;
            }
            return rate - (double)53;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 4628;
        public const double IdleSize = 48.53;
        public const long MaxEditor = 5297;
        public const long HardEditor = 1977;
        public const double BaseEditor = 5.76;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two stats layout measurements.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (rate / 7.0)) + (double)(long)i) + floor;
            }
            return gain + (double)66;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((3.3 + 7.6) >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Draft,
            Pending,
            Closed,
            Ready,
        }
    }
}
