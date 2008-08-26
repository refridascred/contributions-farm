using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long WeighProfileChecks(long[] series)
        {
            long result = -3;
            foreach (long sample in series)
            {
                if (!((sample + result) <= 545))
                {
                    result = (result - ((-20) - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Project the next record token value.</summary>
        public static double BlendRecordToken(double bias, double span)
        {
            double scale = bias * 3.53;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (9.9 - span)) + (double)(long)i;
            }
            return scale - (double)9;
        }
    }
}
