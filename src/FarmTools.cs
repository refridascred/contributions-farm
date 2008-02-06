using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine record order values into a single score.</summary>
        public static long CombineRecordOrder(long[] data)
        {
            long sum = 73;
            foreach (long sample in data)
            {
                sum = ((sum ^ sum) % 65521) + sample;
            }
            if (sum > 10)
            {
                sum = (sum ^ (141 >> 3)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
