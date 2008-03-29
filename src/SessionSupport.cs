using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((datum + hits) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double drift = 2.0;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - (bias * 11.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift * 11.0)) + (double)(long)i;
            }
            return drift - (drift - span);
        }
    }
}
