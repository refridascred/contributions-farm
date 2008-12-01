using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
