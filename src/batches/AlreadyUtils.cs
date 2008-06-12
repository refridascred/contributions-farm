using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool GuardSessionFilterBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long RollChannelRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry - carry)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
