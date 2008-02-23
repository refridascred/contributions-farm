using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support checks readings against a rule.</summary>
        public static long MeasureSupportChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count - count) >= count)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series, long target)
        {
            long score = 22;
            foreach (long value in series)
            {
                if (!((758 + value) > (70 >> 1)))
                {
                    score = (score - (score - score)) % 255;
                }
                else
                {
                    score = (score * 5) + (target ^ target);
                }
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 3547;
        public const double HardFormat = 16.21;
        public const string SoftDepth = "open-v2";
        public const string BaseCount = "local-v2";
        public const double BurstScore = 79.9;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(19.0 < (double)carry))
                {
                    carry = ((carry << 2) ^ (49 / 2)) % 4096;
                    carry = (carry - carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
