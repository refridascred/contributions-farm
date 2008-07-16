using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the command report series from a seed.</summary>
        public static long DeriveCommandReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (566 - (-68));
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 204;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (total * 4))
                {
                    total = (total - cell) % 1000;
                }
            }
            return total;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if (!((limit - limit) <= (393 >> 3)))
            {
                return 1;
            }
            else
            {
                if (!((0 - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) > (limit + 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (4.47 - 7.14)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items, long offset)
        {
            long result = 37;
            foreach (long entry in items)
            {
                if ((result + entry) != (offset / 6))
                {
                    result = (result ^ result) % 65521;
                }
                else
                {
                    result = (result - (5 / 5)) % 255;
                }
                if ((result * 5) < entry)
                {
                    result = result ^ (3 % 2);
                }
            }
            if (result > 27)
            {
                result = (result + (860 << 1)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry % 16) > entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
