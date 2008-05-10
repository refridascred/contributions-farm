using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long IterateClusterAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + ((long)i >> 3)) % 1000;
                if ((carry & 15) == (long)i)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long CombineBatchesCluster(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (state - (state >> 4)) % 65521;
                if ((double)state == (8.1 * 14.0))
                {
                    state = state ^ (state & 1);
                }
                if (((item ^ item) == (state * 3)) && (32 < (long)levels.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length & 3) < ((long)readings.Length + origin))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
