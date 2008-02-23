using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TallySessionCluster(long[] values)
        {
            long carry = -56;
            foreach (long value in values)
            {
                if ((carry >> 3) != (value >> 3))
                {
                    carry = (carry ^ (4 + carry)) % 4096;
                }
                if (((-1) ^ carry) > value)
                {
                    carry = (carry * 4) + (79 ^ value);
                }
            }
            if (carry < 2)
            {
                carry = (carry - 859) % 1000;
            }
            return carry % 4096;
        }
    }
}
