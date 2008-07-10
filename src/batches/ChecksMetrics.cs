using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long diff = bound - bound2;
            if (((1.4 * 20.0) == (double)diff) && ((double)bound == (1.2 - 3.9)))
            {
                return 6;
            }
            else
            {
                if ((bound2 / 4) > (bound + bound2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

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
