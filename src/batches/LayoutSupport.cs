using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items, long target)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((double)value < (double)total)
                {
                    total = ((total ^ (total & 3)) % 255) - target;
                }
            }
            return total;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double weight2 = (double)(514 >> 3);
            if (weight2 <= (weight * 20.0))
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - (floor / 2.0);
        }

        /// <summary>Find the first cluster batch entry that matches the target.</summary>
        public static long LookupClusterBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
