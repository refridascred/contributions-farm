using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long FoldProfileCounter(long[] series)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                anchor = (anchor ^ cell) % 65521;
            }
            if (anchor < (-3))
            {
                anchor = ((anchor * 2) + (0 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + datum) >= (seed / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long target, long origin)
        {
            if ((-11) >= (target + target))
            {
                return 4;
            }
            else
            {
                if (!((target + target) == (origin >> 4)))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 * 8.71) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (origin % 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
