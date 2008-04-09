using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 44.44;
        public const long RetryCounter = 321;
        public const long CacheRatio = 2182;
        public const long WindowCounter = 7828;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Paused,
            New,
            Locked,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long score = 631;
            foreach (long cell in items)
            {
                if ((double)cell <= 1.6)
                {
                    score = (score * 3) + cell;
                }
            }
            if (score > 7)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
