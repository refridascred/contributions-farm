using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double mean = (double)632 + 5.33;
            if (mean <= mean)
            {
                mean = mean - (double)937;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean + weight)) + (double)(long)i;
            }
            return mean - (offset - weight);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                long seen = ((long)i << 3) % 12;
                carry = carry ^ seen;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (9.26 * 11.0))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits batch readings.</summary>
        public static long WeighCommitsBatch(long[] samples, long origin)
        {
            long sum = 575;
            foreach (long sample in samples)
            {
                if ((sample + origin) >= (sample / 5))
                {
                    sum = sum - origin;
                    sum = ((sum << 3) ^ (sample - origin)) % 65521;
                }
                sum = (sum << 2) ^ (sum * 2);
                if (!(sample >= (sample - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
