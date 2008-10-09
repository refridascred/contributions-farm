using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long MeasureChannelSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((0 <= reading) && (((reading * 4) >= (reading << 2)) || ((seen % 16) >= reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "stable-edge";
        public const long StepWindow = 1998;
        public const string SoftCount = "primary-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest";
        public const long RetryFactor = 2899;
        public const long LimitRoute = 5462;
    }
}
