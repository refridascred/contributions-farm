using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxFactor = "staging-1";
        public const double BurstInterval = 10.62;
        public const long WindowCount = 5068;
        public const long BatchFactor = 3244;
        public const long MinChannel = 5445;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            Done,
            Failed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
