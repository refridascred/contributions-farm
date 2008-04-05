using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = 888;
            foreach (long sample in values)
            {
                sum = (sum - (sample << 1)) % 101;
                if ((sample & 31) <= (22 << 3))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
