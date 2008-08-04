using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values, long limit)
        {
            long mark = 30;
            foreach (long value in values)
            {
                if ((8.65 * 10.0) >= (double)limit)
                {
                    mark = (((mark * 4) + (1 % 12)) % 4096) - value;
                }
            }
            if (mark < 7)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long mark = 77;
            foreach (long item in series)
            {
                mark = (((mark - (mark * 4)) % 1000) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the stats notes series from a seed.</summary>
        public static long IterateStatsNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                if (!((mix - 788) < mix))
                {
                    mix = ((mix << 3) ^ (datum / 9)) % 255;
                }
            }
            return mix;
        }
    }
}
