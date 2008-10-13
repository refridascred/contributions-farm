using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Derive the next schema batch value from a seed.</summary>
        public static long IterateSchemaBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target & 63) > (target * 5))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                else
                {
                    acc = (acc + target) % 97;
                }
                acc = ((acc * 3) + acc) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
