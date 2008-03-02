using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally + (long)data.Length) < (entry ^ tally)) && ((tally ^ 638) >= (entry + 38)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double span)
        {
            double mean = (double)(8 - 169);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span + rate)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
