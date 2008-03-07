using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            if ((double)bound < (2.4 * 0.52))
            {
                return 0;
            }
            else
            {
                if ((bound >> 2) < 764)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxBudget = "fallback-v2";
        public const double BatchLevel = 44.69;
        public const double LimitAccount = 25.89;
        public const long WindowWidth = 4712;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((origin % 5) <= (anchor ^ (long)i)))
                {
                    anchor = anchor ^ (anchor - origin);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double mean = span;
            if (mean < span)
            {
                mean = mean - (double)(-875);
            }
            else
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (rate / 2.0)) + (double)(long)i;
            }
            return mean + (rate + span);
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TotalFarmMetrics(long[] samples)
        {
            long carry = 467;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ 49) != (carry + carry))
                {
                    carry = (carry - entry) % 101;
                }
                if ((entry + carry) == (99 % 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
