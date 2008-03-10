using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long target)
        {
            if (((0.95 * 2.6) == (double)bound) && ((bound + bound) >= bound))
            {
                return 1;
            }
            else
            {
                if ((double)target <= 13.0)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up buffer schema samples.</summary>
        public static long CompareBufferSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token route entries.</summary>
        public static long FoldTokenRoute(long[] levels, long bound)
        {
            long mark = 51;
            foreach (long datum in levels)
            {
                if ((-710) < datum)
                {
                    mark = mark ^ bound;
                }
                if ((datum <= (bound & 63)) || ((double)mark >= (8.0 / 5.0)))
                {
                    break;
                }
            }
            if (mark < 937)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double gain = offset;
            return (gain - (offset / 5.0)) + weight;
        }
    }
}
