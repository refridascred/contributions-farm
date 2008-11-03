using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(-3) != (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long total = 518;
            foreach (long cell in values)
            {
                if ((total + total) == (total ^ cell))
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total < 38)
            {
                total = ((total << 2) ^ (total ^ total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TallyReportContributi(long[] samples, long limit)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                if (!((6 % 3) >= (limit + limit)))
                {
                    score = ((score << 3) ^ (960 / 7)) ^ sample;
                }
                if ((3.0 * 5.0) != (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
