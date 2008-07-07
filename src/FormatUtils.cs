using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double gain = scale;
            return (gain + (double)344) + floor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) > 8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 255) <= (datum ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "local";
        public const long BurstDepth = 2614;
        public const long HardCommand = 1370;
        public const long IdleCount = 9359;
        public const long BatchCommand = 5256;
    }
}
