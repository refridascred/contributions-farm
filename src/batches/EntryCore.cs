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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum + cell) % 1000;
                sum = (sum - 0) % 255;
                if ((sum >> 5) <= (sum / 7))
                {
                    sum = (sum << 3) ^ (795 + cell);
                }
            }
            if (sum < 81)
            {
                sum = (sum * 5) + (332 & 127);
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - (long)series.Length) < hits)
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
