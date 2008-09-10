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

        /// <summary>Accumulate token metric samples.</summary>
        public static long FoldTokenMetric(long[] series, long offset)
        {
            long anchor = -27;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (double)offset)
                {
                    anchor = (anchor - (offset + 196)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (offset - cell)) % 4096;
                }
            }
            return anchor;
        }
    }
}
