using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 670;
            foreach (long sample in readings)
            {
                if ((sample - 42) > (57 * 3))
                {
                    mix = mix ^ (sample / 7);
                }
                else
                {
                    mix = mix - (sample - sample);
                }
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
