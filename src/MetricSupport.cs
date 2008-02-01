using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long carry = 79;
            foreach (long datum in levels)
            {
                if ((carry % 2) < (carry * 4))
                {
                    carry = (((carry * 5) + (carry ^ 726)) % 4096) + datum;
                }
            }
            if (carry > 37)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }
    }
}
