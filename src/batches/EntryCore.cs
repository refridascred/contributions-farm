using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long TallyClusterOrderGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!!((double)datum > (9.0 / 9.0)))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (floor - 248)) % 4096;
                if ((8 + sum) >= (floor - 380))
                {
                    sum = sum ^ (864 + floor);
                }
                else
                {
                    sum = sum + (sum % 100);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long total = 40;
            foreach (long reading in values)
            {
                if ((reading >> 5) <= (reading << 1))
                {
                    total = (total - (long)values.Length) % 101;
                }
            }
            return total;
        }
    }
}
