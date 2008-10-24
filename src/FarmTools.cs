using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate channel profile samples.</summary>
        public static long ScoreChannelProfile(long[] readings, long seed)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((((total * 3) + (long)readings.Length) % 97) - reading) - seed;
            }
            if (total > 17)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6556;
        public const double BurstProfile = 24.1;
        public const double SoftProfile = 53.39;
        public const double HardProfile = 17.47;
    }
}
