using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstFactor = "open-1";
        public const long BaseMetrics = 2205;
        public const double BurstMetrics = 4.56;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset - anchor) > (offset + 151))
                {
                    anchor = anchor + (anchor ^ (long)i);
                }
                else
                {
                    anchor = (anchor + (514 - (long)i)) % 97;
                    anchor = ((anchor << 3) ^ (offset + offset)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
