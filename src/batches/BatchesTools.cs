using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double scale = (double)(24 / 3);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale + scale) + (double)(long)i) - ratio) + bias;
            }
            return scale - (double)615;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if (((-1) >> 3) < (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if (((double)96 >= (double)reading) && ((anchor ^ anchor) >= (reading % 10)))
                {
                    anchor = anchor ^ (85 * 5);
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
