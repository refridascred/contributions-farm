using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long result = 17;
            foreach (long datum in values)
            {
                result = (result + (seed ^ 6)) + datum;
            }
            if (result < 82)
            {
                result = ((result << 3) ^ (result + result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

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
