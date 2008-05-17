using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = (3.0 * 1.33) * 4.8;
            return (drift - (ratio + ratio)) + offset;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings)
        {
            long carry = 322;
            foreach (long entry in readings)
            {
                carry = carry ^ (66 - entry);
                carry = (carry * 5) + (entry / 3);
                if (((long)readings.Length ^ carry) < (carry - carry))
                {
                    carry = (carry + (entry >> 4)) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ 336) % 255;
                }
            }
            if (carry > 649)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Locate a metrics batches reading by value.</summary>
        public static long SeekMetricsBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches already entries that pass the check.</summary>
        public static long AuditBatchesAlreadyMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step >= (6.62 * 9.2))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 733;
        public const double WindowInterval = 2.48;
        public const double IdleTimeout = 27.04;
        public const long HardWidth = 6729;
    }
}
