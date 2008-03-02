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

        /// <summary>Look up the position of a checks report sample.</summary>
        public static long LocateChecksReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
