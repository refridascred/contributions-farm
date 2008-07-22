using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                long offset = mix;
                if (87 < (mix ^ offset))
                {
                    offset = offset - mix;
                    offset = ((offset << 3) ^ (mix * 4)) % 255;
                }
                if (target <= (mix * 4))
                {
                    offset = (offset * 5) + (target - 27);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
