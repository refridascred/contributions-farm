using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
