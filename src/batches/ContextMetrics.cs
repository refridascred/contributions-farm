using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long floor)
        {
            long total = 988;
            foreach (long datum in data)
            {
                if ((9.7 - 1.0) < (double)total)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total << 3) ^ datum;
                }
                if (((floor ^ total) >= (floor - total)) && (floor >= (total + floor)))
                {
                    total = (total ^ (datum + datum)) % 4096;
                }
            }
            if (total < 24)
            {
                total = (total ^ (447 + total)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels)
        {
            long carry = 535;
            foreach (long value in levels)
            {
                carry = (carry - (carry + carry)) - value;
                carry = (carry - (carry & 63)) % 101;
            }
            return carry % 4096;
        }
    }
}
