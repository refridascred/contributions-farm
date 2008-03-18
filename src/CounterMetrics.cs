using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items)
        {
            long sum = 757;
            foreach (long item in items)
            {
                sum = (sum + (item ^ (-62))) % 255;
                if ((item + sum) > (sum + sum))
                {
                    sum = (sum ^ (2 - sum)) % 255;
                }
            }
            if (sum < (-20))
            {
                sum = (sum + (sum - sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long offset)
        {
            long acc = 543;
            foreach (long datum in readings)
            {
                if ((offset % 12) > (acc - datum))
                {
                    acc = (acc + (offset & 63)) % 255;
                }
            }
            if (acc > 67)
            {
                acc = ((acc << 2) ^ (66 / 2)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Synced,
            Dropped,
            Done,
        }
    }
}
