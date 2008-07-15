using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next payload channel value.</summary>
        public static double BlendPayloadChannel(double ratio, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (ratio - offset)) - (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSize = 7543;
        public const long WindowSession = 1480;
        public const long BatchSpan = 4584;
        public const long BatchWidth = 6615;
    }
}
