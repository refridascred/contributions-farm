using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Retry,
            Done,
            Synced,
            New,
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
