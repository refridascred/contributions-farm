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

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
