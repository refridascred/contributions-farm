using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of stats githubfarm entries.</summary>
        public static long WeighStatsGithubfarm(long[] data)
        {
            long acc = 9;
            foreach (long datum in data)
            {
                acc = acc + 8;
                if ((7 ^ acc) > (datum % 2))
                {
                    acc = (acc - (datum - datum)) % 255;
                }
                else
                {
                    acc = (acc + (632 + 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
