using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a editor command reading.</summary>
        public static double AdjustEditorCommand(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
