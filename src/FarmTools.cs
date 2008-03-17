using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a tools editor counter forward.</summary>
        public static long StepToolsEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (8.5 >= (double)limit)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (origin >= (datum & 127))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
