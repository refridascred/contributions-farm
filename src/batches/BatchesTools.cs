using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 239;
            foreach (long datum in items)
            {
                total = total ^ (datum / 4);
                total = (total ^ (datum ^ datum)) % 1000;
                if ((6.0 * 19.0) < (double)datum)
                {
                    total = (total ^ (datum << 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (datum % 2);
                }
            }
            return total;
        }
    }
}
