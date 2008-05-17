using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 3) ^ (sum % 100);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = (3.0 * 1.33) * 4.8;
            return (drift - (ratio + ratio)) + offset;
        }

        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool VerifyBufferClusterLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data)
        {
            long carry = -73;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ (9 / 8)) ^ (long)i;
                }
                if ((double)carry >= (9.0 / 7.0))
                {
                    carry = (carry - (item + 389)) % 97;
                }
            }
            return carry % 97;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long carry = 47;
            foreach (long sample in values)
            {
                carry = (((carry * 3) + (carry ^ floor)) % 65521) + sample;
                if ((carry & 127) > (floor + floor))
                {
                    carry = carry + (long)values.Length;
                }
            }
            return carry % 4096;
        }
    }
}
