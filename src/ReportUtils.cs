using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 3204;
        public const long MinCount = 7140;
        public const double IdleNotes = 34.04;
        public const long IdleWidth = 2090;

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
