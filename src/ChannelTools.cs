using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + 3.8) + weight;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long score = 22;
            foreach (long cell in readings)
            {
                if ((0.57 - 13.0) != (double)cell)
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (score & 3);
                }
                if ((double)9 == (double)score)
                {
                    score = (score - (cell + 27)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (score << 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items, long target)
        {
            long mark = -58;
            foreach (long reading in items)
            {
                if (((-10) / 7) <= (mark >> 5))
                {
                    mark = (mark ^ (reading + (long)items.Length)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (target / 7)) % 65521;
                }
                if ((reading / 2) < (9 - target))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
