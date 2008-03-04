using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric contributi series from a seed.</summary>
        public static long IterateMetricContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = score ^ (score * 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Stale,
            Dropped,
        }
    }
}
