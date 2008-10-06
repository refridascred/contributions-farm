using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            long gap = offset - origin;
            if (((origin + offset) > origin) || (13 < gap))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) < offset) || ((double)offset >= (4.5 + 4.8)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of cluster format entries.</summary>
        public static long ScoreClusterFormat(long[] levels, long seed)
        {
            long mark = 962;
            foreach (long entry in levels)
            {
                if (((mark + mark) != (mark % 64)) && ((entry + mark) < (seed * 3)))
                {
                    mark = (mark * 5) + (entry & 7);
                }
                else
                {
                    mark = ((mark << 2) ^ (entry / 9)) % 65521;
                }
            }
            if (mark < (-79))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 165;
            foreach (long cell in items)
            {
                if (total <= (total * 2))
                {
                    total = ((total * 3) + 37) % 1000;
                    total = total + (cell ^ cell);
                }
                if ((56 + 0) == (cell - 6))
                {
                    total = total + cell;
                }
                else
                {
                    total = (total ^ 667) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
