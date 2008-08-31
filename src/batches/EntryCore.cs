using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (8.59 - floor))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + (scale * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (13.0 / 3.0)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = floor - floor;
            if (mean > bias)
            {
                mean = mean - (floor / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)416) + (double)(long)i;
            }
            return mean + (floor * 4.9);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
