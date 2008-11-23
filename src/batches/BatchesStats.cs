using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long bound)
        {
            long carry = -745;
            foreach (long entry in data)
            {
                if (((691 >> 2) != (carry - entry)) && (((-96) - 482) != (carry / 3)))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                    continue;
                }
                carry = (carry * 2) + ((long)data.Length - entry);
                if (((double)entry < 15.0) && (carry >= (bound >> 5)))
                {
                    carry = (carry - (entry + bound)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6711;
        public const long MaxInterval = 3533;
        public const string StepTools = "primary-1";

        /// <summary>Check that every tools order entry stays within the limit.</summary>
        public static bool VerifyToolsOrderRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Synced,
            Ready,
            Pending,
            Draft,
        }
    }
}
