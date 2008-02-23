using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double scale = (double)(9 & 127);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - span;
            }
            return scale - (11.0 + ratio);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = state - (limit + limit);
                state = state - (state << 2);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
