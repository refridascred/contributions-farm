using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (floor + result)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
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
