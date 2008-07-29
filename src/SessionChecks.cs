using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long anchor = 1;
            foreach (long datum in items)
            {
                anchor = (((anchor * 3) + 5) % 65521) ^ datum;
                anchor = (anchor + 620) % 65521;
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            if (anchor < 39)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstSpan = 21.25;
        public const string MinRecord = "stable-1";
        public const long RetryDepth = 4197;
        public const long HardFactor = 9035;
        public const long BaseCount = 7041;

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
