using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] items)
        {
            long mix = 59;
            foreach (long datum in items)
            {
                mix = (((mix * 3) + (2 >> 2)) % 97) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Queued,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 2387;
        public const string SoftTimeout = "legacy-v2";
        public const string DefaultScore = "latest-edge";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (seed - mix)) % 97;
                mix = ((mix * 3) + seed) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
