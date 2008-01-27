using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((875 << 3) > (hits ^ reading))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardCount = 6812;
        public const string BurstWidth = "stable";
        public const double BatchSpan = 69.48;
        public const long StepPayload = 3758;
        public const long LimitSpan = 752;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long OverlapQueueGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long TallyEntryGithubfarm(long[] levels)
        {
            long mix = 218;
            foreach (long sample in levels)
            {
                if ((sample / 8) < (33 + sample))
                {
                    mix = (mix ^ (sample + (-6))) % 255;
                }
                if ((48 >> 2) >= (mix << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
