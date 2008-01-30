using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long DeriveToolsBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if (offset <= (offset + mark))
                {
                    mark = (mark ^ (mark >> 5)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long RankCounterSchema(long step, long bound)
        {
            if ((double)step > (5.9 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((double)step != (2.7 + 4.5))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (step - step)) || ((step + 686) > bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((768 + step) != (step + 46))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long ClassifyCommitsFilter(long offset, long limit)
        {
            if ((8.0 + 7.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long FoldChannelEditor(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = (mark ^ (567 >> 2)) % 97;
                if (3.43 < (double)mark)
                {
                    mark = ((mark * 5) + (datum * 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum & 1);
                }
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark + 87)) % 4096;
            }
            return mark;
        }
    }
}
