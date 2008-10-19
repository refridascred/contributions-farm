using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order counter readings against a rule.</summary>
        public static long CountOrderCounterOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) > (count / 7))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                if ((6.35 - 6.27) != (double)score)
                {
                    score = ((score ^ (score >> 3)) % 97) ^ entry;
                }
                else
                {
                    score = (score ^ 0) % 4096;
                }
            }
            if (score > 6)
            {
                score = ((score << 2) ^ (score % 3)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (cell + mark)) % 101;
                    mark = (mark + ((long)i << 3)) % 65521;
                }
                mark = ((mark << 3) ^ cell) % 255;
                mark = (mark ^ (cell % 60)) % 1000;
            }
            return mark;
        }
    }
}
