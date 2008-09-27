using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long SortMetricsCommand(long seed, long limit)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((limit + limit) >= (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) != (seed / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a commits graph reading.</summary>
        public static double ProjectCommitsGraph(double weight, double offset)
        {
            double load = (double)(67 << 1);
            if (load >= (load * 5.2))
            {
                load = (load + (double)172) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            long cur = limit ^ bound;
            if ((2.4 * 3.22) < (double)cur)
            {
                return 3;
            }
            else
            {
                if ((cur - limit) <= (cur << 1))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 10) > (bound ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
