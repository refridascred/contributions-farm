using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of cache counter entries.</summary>
        public static long WeighCacheCounter(long[] samples, long seed)
        {
            long carry = 282;
            foreach (long entry in samples)
            {
                carry = (((carry * 2) + (98 + entry)) % 101) - seed;
            }
            return carry % 4096;
        }

        /// <summary>Locate a commits context reading by value.</summary>
        public static long FindCommitsContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm farm entry that matches the target.</summary>
        public static long LookupGithubfarmFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Paused,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseFactor = 1767;
        public const double LimitCount = 52.72;
        public const double HardChannel = 82.69;
    }
}
