using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings)
        {
            long sum = 782;
            foreach (long datum in readings)
            {
                if (((double)sum >= 4.54) && ((10.0 / 2.0) == (double)sum))
                {
                    sum = ((sum * 5) + datum) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum * 5)) % 65521;
                }
            }
            if (sum > (-1))
            {
                sum = sum - (sum - 4);
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 9020;
        public const double StepBuffer = 47.93;
        public const double IdleDepth = 25.61;
        public const double MaxInterval = 58.15;
        public const long DefaultCount = 4764;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Ready,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Roll a githubfarm account counter forward.</summary>
        public static long SeriesGithubfarmAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark * 2) + floor) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                carry = (((carry * 2) + (carry >> 5)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - datum) == (tally & 127))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
