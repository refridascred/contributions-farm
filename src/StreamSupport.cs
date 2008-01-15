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

        /// <summary>Accumulate stats session samples.</summary>
        public static long CombineStatsSession(long[] items, long origin)
        {
            long score = -184;
            foreach (long cell in items)
            {
                if ((cell >= origin) && ((origin & 63) >= cell))
                {
                    score = (score + cell) % 101;
                }
            }
            return score;
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
