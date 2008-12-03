using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry + 3) >= (entry / 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double ratio = rate + (span * 20.0);
            if (ratio <= 3.0)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
