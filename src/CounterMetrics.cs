using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if (!((datum << 2) > datum))
                {
                    anchor = ((anchor * 3) + (floor - datum)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum & 31);
                    anchor = (anchor + (anchor << 1)) % 255;
                }
                anchor = anchor + (datum >> 2);
            }
            if (anchor > 297)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Combine token support values into a single score.</summary>
        public static long ScoreTokenSupport(long[] values, long seed)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ datum) % 255;
            }
            if (mark < (-366))
            {
                mark = ((mark << 2) ^ (seed % 100)) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 7.89))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (gain * 0.5);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)35;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
