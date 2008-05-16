using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
