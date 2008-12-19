using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                long matches = (mix >> 2) - (seed + mix);
                if (!!((30 / 2) == (matches + (long)i)))
                {
                    mix = (mix + 702) % 101;
                    matches = ((matches << 2) ^ (646 << 1)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8454;
        public const long SoftFactor = 4041;
        public const string IdleStream = "latest-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
