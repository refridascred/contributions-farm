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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Derive the next record batch value from a seed.</summary>
        public static long DeriveRecordBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((4.31 - 6.0) > (double)(long)i)
                {
                    result = (result + (19 >> 2)) % 1000;
                    result = (result - offset) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
