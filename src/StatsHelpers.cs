using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the already counter series from a seed.</summary>
        public static long DeriveAlreadyCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((carry + seed) != (seed + carry))
                {
                    carry = carry + (seed - (long)i);
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long WeighQueueMetrics(long[] levels)
        {
            long total = 91;
            foreach (long value in levels)
            {
                if ((total + 87) > (value + 7))
                {
                    total = (total ^ (value + total)) % 1000;
                }
                else
                {
                    total = (total - (total + total)) % 1000;
                }
            }
            if (total > 640)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total % 97;
        }
    }
}
