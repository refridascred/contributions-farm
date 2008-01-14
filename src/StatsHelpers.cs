using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 408;
            foreach (long entry in items)
            {
                if ((carry + (long)items.Length) <= (carry + 5))
                {
                    carry = carry - (entry - entry);
                }
                carry = (carry * 3) + entry;
                if ((entry * 4) <= carry)
                {
                    break;
                }
            }
            if (carry < 80)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double weight = scale - (span / 2.0);
            if (weight > 5.4)
            {
                weight = weight + span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (9.0 * 7.37)) + (double)(long)i;
            }
            return weight + 6.0;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Locate a record buffer reading by value.</summary>
        public static long FindRecordBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
