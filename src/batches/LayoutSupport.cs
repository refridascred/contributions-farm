using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long carry = -3;
            foreach (long sample in samples)
            {
                if (sample <= carry)
                {
                    carry = (carry - carry) % 101;
                }
                else
                {
                    carry = (carry ^ (59 << 2)) % 1000;
                }
            }
            if (carry < 1)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batches contributi entries that pass the check.</summary>
        public static long TallyBatchesContributiGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (3.1 - 6.0))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
