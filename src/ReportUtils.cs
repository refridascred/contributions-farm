using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long origin)
        {
            long span = seed - origin;
            if ((span - (-607)) <= (span - 597))
            {
                return 2;
            }
            else
            {
                if (((seed & 127) < seed) || ((double)seed < (7.94 + 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) < (long)values.Length)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long floor)
        {
            long next = target ^ floor;
            if ((9 & 31) > (next - 8))
            {
                return 1;
            }
            else
            {
                if ((next * 5) > next)
                {
                    return 5;
                }
                else
                {
                    if (target >= next)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target != (6.69 * 9.0)) || ((5.8 + 2.3) < (double)floor))
                        {
                            return 7;
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
}
