using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - limit) % 65521) + entry;
                    sum = (sum + (long)i) % 65521;
                }
                sum = (sum * 2) + (limit % 7);
            }
            if (sum > (-32))
            {
                sum = ((sum * 2) + (44 - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
