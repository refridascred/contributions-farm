using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + 37) == (entry / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit <= 454) && (13.0 >= (double)(long)i))
                {
                    acc = (acc - (acc - limit)) % 97;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = (acc ^ limit) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
