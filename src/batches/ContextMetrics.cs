using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double load = offset;
            return load + ratio;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = -2;
            foreach (long datum in levels)
            {
                mark = (mark + (72 % 2)) - datum;
                mark = (mark - (mark & 255)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            long lane = offset + offset2;
            if (((lane << 1) == (offset2 >> 1)) || ((lane >> 1) != (lane + offset)))
            {
                return 5;
            }
            else
            {
                if (!((double)lane <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long CountFormatChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((0 * 5) >= count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i & 31) > 5)
                {
                    total = total - (total / 4);
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                if ((8.83 / 4.0) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    total = total - (step * 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
