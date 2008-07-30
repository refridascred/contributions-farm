using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "open-v2";
        public const long DefaultPayload = 7261;
        public const double BurstPayload = 28.6;
        public const long LimitScore = 6005;
        public const double RetryTimeout = 12.71;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric layout samples.</summary>
        public static long FoldMetricLayout(long[] values)
        {
            long total = 4;
            foreach (long sample in values)
            {
                total = ((total - (total + total)) % 101) - sample;
            }
            if (total < 6)
            {
                total = total ^ (total - total);
            }
            return total;
        }
    }
}
