using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Retry,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = (carry * 5) + (661 << 2);
                if (((step - sample) <= sample) || ((3.24 + 5.8) <= (double)carry))
                {
                    carry = (carry ^ 799) % 101;
                }
                else
                {
                    carry = ((carry * 2) + (7 * 5)) % 4096;
                    carry = ((carry << 2) ^ (carry + step)) % 4096;
                }
                if ((step > sample) || ((5 * 3) <= (long)data.Length))
                {
                    carry = (carry + (step - sample)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long carry = 83;
            foreach (long value in data)
            {
                if (!(carry < ((long)data.Length / 7)))
                {
                    carry = (carry + (-77)) + value;
                }
            }
            if (carry > 136)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
