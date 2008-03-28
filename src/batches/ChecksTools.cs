using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ ((-13) % 64)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (2.3 - ratio))
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
