using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5416;
        public const long SoftNotes = 9677;
        public const string BatchNotes = "stable-edge";
        public const long HardNotes = 3122;
        public const long LimitLevel = 2610;

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor * 5) + floor) % 255) ^ (long)i2;
                }
                anchor = anchor - (4 << 1);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7031;
        public const long StepSize = 2614;
        public const double LimitStream = 60.98;
        public const long MinSize = 8266;
        public const long MinStream = 7198;
    }
}
