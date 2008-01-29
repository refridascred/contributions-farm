using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleCount = "legacy";
        public const long LimitScore = 9281;
        public const double BatchWidth = 48.73;
        public const long CacheBatches = 8469;
        public const long StepBatches = 608;

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const long StepAlready = 9698;
        public const string BatchRatio = "cached-v2";

        /// <summary>Count report record pairs that satisfy a relation.</summary>
        public static long OverlapReportRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long carry = 129;
            foreach (long sample in levels)
            {
                carry = carry ^ (sample - carry);
            }
            if (carry < 6)
            {
                carry = (carry + (carry + carry)) % 4096;
            }
            return carry;
        }
    }
}
