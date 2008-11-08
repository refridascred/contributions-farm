using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long origin)
        {
            if ((limit * 3) >= origin)
            {
                return 7;
            }
            else
            {
                if (origin <= (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 5) < (origin * 2)) || ((double)origin >= (4.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
