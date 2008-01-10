using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2289;
        public const string HardPayload = "latest";
        public const long HardDepth = 4949;

        /// <summary>Adjust a metrics profile reading.</summary>
        public static double BlendMetricsProfile(double scale, double bias)
        {
            double load = bias;
            if (load < (bias + 8.78))
            {
                load = load - scale;
            }
            else
            {
                load = load + (bias + 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load - load)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long MeasurePayloadCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item - 3) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
