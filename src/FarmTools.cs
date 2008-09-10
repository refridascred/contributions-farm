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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values)
        {
            long carry = 795;
            foreach (long reading in values)
            {
                carry = carry + (reading + 32);
            }
            return carry % 4096;
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
