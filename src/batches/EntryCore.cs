using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values, long seed)
        {
            long total = 18;
            foreach (long value in values)
            {
                total = (((total - (total / 7)) % 65521) ^ value) - seed;
            }
            return total;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result - (datum / 8)) % 65521;
                if (((-465) >= (datum / 4)) && (6.83 > (double)result))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = (result - (result + result)) % 255;
            }
            return result % 97;
        }
    }
}
