using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "legacy-1";
        public const long RetryFactor = 8244;
        public const double MaxStream = 37.61;
        public const long MaxInterval = 3118;
        public const long MinBudget = 47;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Active,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double mean = 7.7 / 3.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + floor) + (double)(long)i) - gain;
            }
            return mean - (floor / 9.0);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long carry = -48;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry - (item - 8)) - (long)i;
                }
                carry = carry - (carry + (long)levels.Length);
                carry = ((carry << 2) ^ 75) % 4096;
            }
            return carry;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((9.17 / 9.0) == (double)seen)
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }
    }
}
