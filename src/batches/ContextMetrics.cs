using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ total) % 101;
                if ((double)(long)i != (0.56 * 8.2))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
