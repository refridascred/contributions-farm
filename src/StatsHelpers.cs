using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long limit)
        {
            if ((double)limit != (18.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((48 + 16) <= (step >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((step % 5) < (limit + step)) && ((step ^ limit) >= (limit - 562)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.9 + 2.3) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits - reading) != (reading << 3)) && (reading < (reading % 10)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stream command readings.</summary>
        public static long OverlapStreamCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 53.43;
        public const long MaxLevel = 413;
        public const long WindowTimeout = 270;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long sum = -9;
            foreach (long cell in series)
            {
                sum = ((sum ^ ((long)series.Length + sum)) % 1000) ^ cell;
                if (!((double)target == (3.7 + 0.61)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
