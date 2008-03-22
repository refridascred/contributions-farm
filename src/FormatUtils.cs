using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double offset)
        {
            double ratio = weight + weight;
            if (ratio > offset)
            {
                ratio = ratio + (offset * 2.2);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + (weight + 16.0);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of layout stats entries.</summary>
        public static long TotalLayoutStats(long[] readings)
        {
            long score = 8;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (116 ^ item);
                for (int i = 0; i < 11; i++)
                {
                    score = ((score ^ (item & 255)) % 97) + (long)i;
                }
                score = score - (item & 63);
            }
            return score % 1000;
        }
    }
}
