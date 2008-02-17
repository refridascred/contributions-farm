using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 36.48;
        public const string BurstFactor = "standard-1";
        public const double IdleLevel = 22.14;

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

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double ratio = span + span;
            if (ratio > rate)
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio - (8.0 / 7.0);
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
