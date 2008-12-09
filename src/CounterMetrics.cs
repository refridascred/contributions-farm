using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings, long limit)
        {
            long total = -87;
            foreach (long reading in readings)
            {
                if ((5.69 < (double)limit) && (568 > (limit / 2)))
                {
                    total = ((total * 5) + (reading + limit)) % 4096;
                }
            }
            if (total < (-603))
            {
                total = (total << 3) ^ (total * 2);
            }
            return total;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = (double)628 * 2.7;
            if (load >= (scale / 8.0))
            {
                load = (load + load) + offset;
            }
            else
            {
                load = load - (load * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor / 7) != (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.59 / 2.0) == (double)step)
                        {
                            return 4;
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
