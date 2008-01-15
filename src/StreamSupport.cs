using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long limit)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                if (((datum - 80) >= (total & 7)) && (limit <= total))
                {
                    total = (total + limit) % 65521;
                }
            }
            return total;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (load / 8.0)) + (double)(long)i) - span;
            }
            return load - load;
        }
    }
}
