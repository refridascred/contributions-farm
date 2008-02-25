using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Pending,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if (((-7) + (-82)) >= bound)
            {
                return 6;
            }
            else
            {
                if ((9.0 > (double)seed) && (seed > (seed + 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Paused,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((carry >> 1) == (carry % 97)) || (8.7 <= (double)limit))
                {
                    carry = carry - carry;
                }
                carry = (carry - (3 + carry)) % 65521;
                carry = carry + limit;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the graph command series from a seed.</summary>
        public static long SeriesGraphCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
