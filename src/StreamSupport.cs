using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long score = 82;
            foreach (long item in levels)
            {
                if (score >= (score / 9))
                {
                    score = (score << 2) ^ (item * 5);
                }
            }
            if (score < 7)
            {
                score = score ^ (476 >> 3);
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
