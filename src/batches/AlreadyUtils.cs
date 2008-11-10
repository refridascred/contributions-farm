using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (double)offset) || !((2.05 - 7.9) != (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long OverlapCommitsStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 65.49;
        public const long BurstStats = 7921;
        public const string IdleTimeout = "strict-1";
        public const long HardStats = 8969;
        public const long BatchStats = 3442;
    }
}
