using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double mean = (double)(34 + 4);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + mean) + (double)(long)i) - gain;
            }
            return mean - bias;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
