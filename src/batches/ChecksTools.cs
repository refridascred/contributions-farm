using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Idle,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double scale = 7.7;
            if (scale <= bias)
            {
                scale = (scale + bias) - bias2;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale * 8.6)) + (double)(long)i;
            }
            return scale + 6.3;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxDepth = 1767;
        public const string HardInterval = "strict-edge";
        public const long SoftCommand = 5518;
    }
}
