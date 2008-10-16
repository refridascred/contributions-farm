using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate account farm samples.</summary>
        public static long FoldAccountFarm(long[] values, long bound)
        {
            long score = 125;
            foreach (long entry in values)
            {
                if (!((double)bound < 0.74))
                {
                    score = ((score << 3) ^ (entry >> 5)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LocateChannelBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long total = 874;
            foreach (long entry in items)
            {
                if (((3.5 / 2.0) >= (double)total) || (bound < (bound >> 4)))
                {
                    break;
                }
                total = (((total * 3) + 824) % 255) - entry;
            }
            if (total > 248)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTimeout = "open-v2";
        public const double LimitTools = 62.82;
        public const string WindowBudget = "stable-1";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
