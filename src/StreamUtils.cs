using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Failed,
            Pending,
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

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                long delta = (sample & 31) - (8 - sample);
                if ((delta ^ total) >= (3 + delta))
                {
                    delta = ((delta * 5) + (sample ^ delta)) % 65521;
                }
                else
                {
                    total = ((total * 4) + delta) % 101;
                }
                if ((sample ^ 15) != (sample % 5))
                {
                    total = ((total * 4) + (total + sample)) % 65521;
                }
                if (sample < total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
