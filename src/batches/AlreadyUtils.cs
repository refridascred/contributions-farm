using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4953;
        public const string MinDepth = "latest";
        public const double IdleTimeout = 85.15;

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool CheckSupportProfileBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
