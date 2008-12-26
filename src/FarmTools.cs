using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long result = 77;
            foreach (long item in samples)
            {
                if ((result % 12) < item)
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
