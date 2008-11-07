using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items)
        {
            long carry = 0;
            foreach (long item in items)
            {
                if (((carry + carry) == (item % 7)) && ((item & 31) < (carry - 87)))
                {
                    carry = (carry << 2) ^ (item & 1);
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long mix = 62;
            foreach (long cell in data)
            {
                if (!((long)data.Length <= 958))
                {
                    mix = (mix + (cell - mix)) % 65521;
                }
            }
            if (mix > 694)
            {
                mix = ((mix * 2) + (seed << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + ((long)i + (long)i);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (4.0 - 5.6))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (375 + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
