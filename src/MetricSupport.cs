using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long offset)
        {
            long delta = target + offset;
            if ((9 + target) == (1 + delta))
            {
                return 4;
            }
            else
            {
                if (!((target + 8) > (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardFactor = 4031;
        public const long HardNotes = 9643;
        public const long BaseNotes = 4613;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
