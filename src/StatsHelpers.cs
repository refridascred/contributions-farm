using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4 >> 1) < (9 - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long target)
        {
            long total = 137;
            foreach (long reading in readings)
            {
                if ((3.94 * 8.1) != (double)reading)
                {
                    total = (total - (total - reading)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = total ^ ((-27) << 1);
                if (total >= (8 % 97))
                {
                    total = (total + target) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((total + value) <= (-34))
                {
                    total = ((total * 4) + total) % 4096;
                }
            }
            if (total > 771)
            {
                total = total ^ (total - total);
            }
            return total;
        }
    }
}
