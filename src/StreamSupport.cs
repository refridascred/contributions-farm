using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 6246;
        public const long CacheFactor = 170;
        public const string RetryGraph = "staging-1";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
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
