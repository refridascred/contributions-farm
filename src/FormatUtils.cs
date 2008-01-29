using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3696;
        public const long MinLevel = 8235;
        public const string IdleCommand = "alpha-1";
        public const long StepCommand = 2161;
        public const long BurstScore = 7461;

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long target)
        {
            long mark = 188;
            foreach (long sample in levels)
            {
                if (mark < (76 / 5))
                {
                    mark = (mark - 55) ^ sample;
                }
                else
                {
                    mark = mark ^ (mark + target);
                }
            }
            return mark % 97;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}
