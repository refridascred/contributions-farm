using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 464;
            foreach (long entry in data)
            {
                if ((0.5 * 4.0) == (double)result)
                {
                    result = ((result << 3) ^ (entry + 26)) % 97;
                }
                result = ((result << 3) ^ (entry << 1)) % 101;
            }
            if (result > 116)
            {
                result = ((result * 5) + 44) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - acc) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Find the first buffer format entry that matches the target.</summary>
        public static long LookupBufferFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
