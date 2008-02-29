using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (offset >> 5)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long bound)
        {
            long mix = -2;
            foreach (long reading in levels)
            {
                if (((bound * 5) > (bound >> 1)) || ((mix - reading) > (reading << 3)))
                {
                    mix = (mix << 2) ^ (reading / 4);
                }
            }
            if (mix > 618)
            {
                mix = (mix << 3) ^ 84;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 7570;
        public const long DefaultContributi = 3833;
        public const string CacheRatio = "fallback-edge";
    }
}
