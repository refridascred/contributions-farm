using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (6 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long score = 823;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (11 - cell)) % 97) ^ (long)i;
                }
                if ((score % 24) < (cell << 2))
                {
                    score = ((score * 3) + (339 * 4)) % 255;
                    continue;
                }
                if ((limit + cell) < limit)
                {
                    score = (score ^ (5 - limit)) % 101;
                }
            }
            if (score > 187)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((406 - limit) == (864 & 255))
            {
                return 1;
            }
            else
            {
                if (((offset2 >> 5) > (limit + limit)) && ((limit % 2) <= offset2))
                {
                    return 2;
                }
                else
                {
                    if (54 > (offset * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
