using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((mix % 12) > offset)
                {
                    mix = (mix << 2) ^ (mix - offset);
                }
                mix = (mix ^ (mix >> 3)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 4.63;
        public const long SoftRoute = 1227;
        public const long BaseDepth = 5234;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 3915;
        public const long MaxCluster = 1509;
        public const long BurstCluster = 9368;
    }
}
