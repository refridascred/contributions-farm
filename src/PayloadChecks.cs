using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardCount = 6435;
        public const long BurstProfile = 4266;
        public const double BatchLevel = 51.87;
        public const string StepInterval = "strict";
        public const long SoftProfile = 6053;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long floor)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                state = ((state ^ (sample << 1)) % 65521) - floor;
            }
            return state;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (850 * 3)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftDepth = "standard-1";
        public const double CacheFormat = 29.3;
        public const string SoftFormat = "local-1";
        public const string MaxFormat = "cached";
    }
}
