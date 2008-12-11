using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double rate = (bias - offset) * 0.59;
            if (rate < (bias * 6.35))
            {
                rate = rate + rate;
            }
            return rate - rate;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool VerifyEntryFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long carry = 44;
            foreach (long cell in samples)
            {
                carry = (carry << 3) ^ cell;
                carry = ((carry * 2) + cell) % 1000;
                if (carry <= (-624))
                {
                    carry = carry ^ (carry % 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools batch values into a single score.</summary>
        public static long FoldToolsBatch(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                if (((7 - carry) >= reading) || ((carry * 2) >= (reading << 3)))
                {
                    carry = (carry - (carry + reading)) % 97;
                }
                else
                {
                    carry = (carry + (reading >> 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
