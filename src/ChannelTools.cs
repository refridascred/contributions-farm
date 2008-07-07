using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values, long limit)
        {
            long sum = 660;
            foreach (long datum in values)
            {
                if ((777 & 31) >= (sum & 31))
                {
                    sum = sum - (datum << 3);
                }
            }
            if (sum < 71)
            {
                sum = sum + limit;
            }
            return sum;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double scale = (ratio / 2.0) - (span / 6.0);
            if (scale <= (ratio / 4.0))
            {
                scale = scale - (ratio - 6.78);
            }
            else
            {
                scale = scale - (double)486;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (double)89;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
