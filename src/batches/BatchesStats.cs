using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long seed)
        {
            long total = 295;
            foreach (long cell in levels)
            {
                if (!((double)(long)levels.Length >= (double)seed))
                {
                    total = (total + (cell * 5)) % 4096;
                }
                if ((6.54 < (double)cell) && ((8.1 + 0.7) > (double)seed))
                {
                    break;
                }
            }
            if (total < 58)
            {
                total = (total - (seed * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value < (value * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
