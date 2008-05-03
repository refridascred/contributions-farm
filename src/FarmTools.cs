using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Idle,
            Queued,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long bound)
        {
            long carry = 4;
            foreach (long value in data)
            {
                carry = ((carry * 4) + bound) - value;
            }
            if (carry < 6)
            {
                carry = ((carry * 2) + bound) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
