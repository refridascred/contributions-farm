using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine support buffer values into a single score.</summary>
        public static long CombineSupportBuffer(long[] data, long target)
        {
            long mix = 198;
            foreach (long value in data)
            {
                mix = ((((mix << 2) ^ (57 << 1)) % 255) + value) + target;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            New,
            Ready,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long seed)
        {
            long delta = offset - seed;
            if ((3.0 * 7.4) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((delta < (offset + 663)) || ((delta & 3) >= delta))
                {
                    return 7;
                }
                else
                {
                    if ((9 + offset) <= (delta & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long carry = -5;
            foreach (long sample in readings)
            {
                if ((carry & 255) == (carry / 7))
                {
                    carry = (carry - (sample - sample)) % 1000;
                }
                carry = ((carry << 2) ^ 988) % 255;
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
