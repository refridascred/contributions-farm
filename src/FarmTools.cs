using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double gain = weight;
            if (gain < floor)
            {
                gain = gain - (double)976;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + 17.0;
        }

        /// <summary>Count batches tools pairs that satisfy a relation.</summary>
        public static long OverlapBatchesToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
