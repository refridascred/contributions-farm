using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 902;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (sample & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((1 >= (step + (long)values.Length)) || ((799 * 2) < step))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 5145;
        public const long BatchWidth = 5083;
        public const long BaseTimeout = 1254;
        public const string SoftDepth = "legacy-1";

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long mark = 81;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (step << 3)) % 4096) ^ cell;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = rate;
            if (drift > (drift - drift))
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
