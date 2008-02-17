using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 1141;
        public const long HardTimeout = 1525;
        public const double MaxTools = 88.96;
        public const long DefaultTools = 3651;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (target + (long)i)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long CountGraphCacheHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)seed > (1.73 * 10.0))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Ready,
            Dropped,
            Retry,
            Closed,
        }
    }
}
