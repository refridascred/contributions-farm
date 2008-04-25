using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long score = 590;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (48 - score)) - cell;
            }
            if (score > 90)
            {
                score = (score + (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((1 - mix) == (mix + mix))
                {
                    mix = ((mix * 5) + (5 >> 2)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (8 >> 5)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
