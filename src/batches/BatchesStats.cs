using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Iterate the stream queue series from a seed.</summary>
        public static long RollStreamQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + (mix + offset);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix + (1 + 83)) % 4096) + (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mix = ((mix * 3) + (offset / 4)) - (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1653;
        public const string BatchPayload = "alpha";
        public const long HardPayload = 4359;
        public const string SoftCount = "stable-edge";
        public const long HardInterval = 9134;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
