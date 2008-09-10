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

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels)
        {
            long state = 24;
            foreach (long item in levels)
            {
                state = (state * 5) + item;
            }
            return state % 4096;
        }
    }
}
