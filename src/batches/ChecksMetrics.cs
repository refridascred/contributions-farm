using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ seed) <= (sum - seed))
                {
                    sum = (sum - (seed % 3)) % 4096;
                }
                sum = sum ^ 86;
                if (!((731 << 1) != (sum >> 4)))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine stats report values into a single score.</summary>
        public static long ScoreStatsReport(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) < datum)
                {
                    total = (total - (datum - total)) % 97;
                }
                if ((datum + total) <= (total * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Derive the next entry cache value from a seed.</summary>
        public static long RollEntryCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ (carry * 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit < seen) && ((item - limit) != ((-553) >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
