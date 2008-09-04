using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((seen - offset) >= (offset - cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double offset)
        {
            double rate = (offset + offset) / 3.0;
            return (rate + (double)980) + weight;
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
