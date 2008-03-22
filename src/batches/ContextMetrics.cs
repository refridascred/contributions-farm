using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool GuardSessionProfileRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cache farm counter forward.</summary>
        public static long RollCacheFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long mark = -810;
            foreach (long value in values)
            {
                mark = mark ^ value;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long step2)
        {
            long offset = step ^ step2;
            if (step2 <= 6)
            {
                return 8;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    if (!((step2 + step2) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((2.3 * 0.16) <= (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
