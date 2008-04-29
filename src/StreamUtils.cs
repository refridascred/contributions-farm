using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3454;
        public const long RetryLevel = 3009;
        public const long WindowReport = 8768;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long acc = 221;
            foreach (long value in series)
            {
                if ((seed + seed) >= acc)
                {
                    acc = ((acc * 5) + value) % 101;
                }
            }
            if (acc > (-91))
            {
                acc = acc + (0 + seed);
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
