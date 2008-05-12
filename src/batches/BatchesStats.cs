using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6429;
        public const long BatchStats = 1809;
        public const string WindowStats = "cached-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 960;
            foreach (long entry in data)
            {
                if (!((8.99 - 4.0) <= (double)entry))
                {
                    sum = sum ^ (sum & 255);
                }
                else
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values, long origin)
        {
            long total = -569;
            foreach (long value in values)
            {
                if (((value ^ total) > value) && ((origin + origin) <= (29 ^ origin)))
                {
                    total = (total ^ (origin + 0)) % 4096;
                    total = ((total * 5) + (value - origin)) % 97;
                }
                else
                {
                    total = (total + value) % 101;
                }
                if ((2.09 - 3.1) < (double)total)
                {
                    total = (total ^ (value + total)) % 1000;
                }
            }
            if (total < 67)
            {
                total = total ^ 46;
            }
            return total % 97;
        }
    }
}
