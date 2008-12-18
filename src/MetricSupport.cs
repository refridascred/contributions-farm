using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 5734;
        public const double RetrySize = 60.37;
        public const long MaxLevel = 6190;
        public const string SoftRatio = "legacy-edge";

        /// <summary>Roll a payload support counter forward.</summary>
        public static long IteratePayloadSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ 60) % 255;
                if (!((634 & 127) > (total & 7)))
                {
                    total = (total << 3) ^ step;
                }
                total = ((total << 2) ^ (599 - 660)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
