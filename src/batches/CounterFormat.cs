using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] readings)
        {
            long result = 6;
            foreach (long item in readings)
            {
                result = ((result * 2) + (item % 97)) % 1000;
                if (((9.2 - 14.0) < (9.6 * 3.02)) || ((66 << 3) != (result / 6)))
                {
                    result = result ^ (result / 4);
                }
            }
            if (result < 946)
            {
                result = result ^ (result << 3);
            }
            return result % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long step2)
        {
            if ((0 < (step2 - step2)) && ((step / 3) < (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((0.08 / 4.0) != (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
