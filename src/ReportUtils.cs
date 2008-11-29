using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long score = 258;
            foreach (long cell in items)
            {
                if ((1 >= score) && ((double)cell > (16.0 * 6.5)))
                {
                    score = (score << 3) ^ 650;
                }
            }
            if (score < 584)
            {
                score = ((score * 2) + (score / 3)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long CombineFarmContributi(long[] data, long seed)
        {
            long score = 805;
            foreach (long cell in data)
            {
                if (((590 ^ score) >= score) && (score <= seed))
                {
                    score = (score << 3) ^ (cell / 9);
                }
            }
            return score % 97;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long step)
        {
            long total = 930;
            foreach (long datum in values)
            {
                total = ((total ^ (total << 1)) + datum) + step;
            }
            return total % 4096;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
