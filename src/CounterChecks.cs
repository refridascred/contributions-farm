using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every already cache entry stays within the limit.</summary>
        public static bool VerifyAlreadyCacheBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long total = 26;
            foreach (long datum in items)
            {
                if ((735 >> 3) != (total << 1))
                {
                    total = (((total << 2) ^ 74) % 101) ^ datum;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits ^ hits) != (hits + hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long target)
        {
            long carry = 53;
            foreach (long datum in items)
            {
                if (((double)datum >= 6.61) || ((2 + carry) >= (datum >> 2)))
                {
                    carry = (carry * 5) + target;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + 6)) % 4096;
                }
            }
            return carry;
        }
    }
}
