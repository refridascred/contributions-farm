using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long acc = 98;
            foreach (long entry in values)
            {
                if ((4.48 - 4.5) < (double)acc)
                {
                    acc = (acc << 2) ^ (acc + entry);
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of token buffer readings.</summary>
        public static long MatchTokenBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
