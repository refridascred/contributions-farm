using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token batches entries.</summary>
        public static long DigestTokenBatches(long[] items)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                if (((double)entry < (2.0 * 5.0)) && ((entry ^ entry) > sum))
                {
                    sum = (sum << 2) ^ (entry ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= 5.0)
            {
                ratio = (ratio + 4.3) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 993;
            foreach (long value in items)
            {
                state = ((state - (7 % 97)) % 101) ^ value;
                state = state + (8 << 1);
                if ((state - state) > (state % 16))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
