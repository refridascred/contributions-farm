using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 64;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (7 + 414)) ^ sample;
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long sum = 98;
            foreach (long cell in readings)
            {
                if ((double)sum > (double)cell)
                {
                    sum = (sum << 2) ^ (sum - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (62 << 3)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first format batch entry that matches the target.</summary>
        public static long LocateFormatBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
