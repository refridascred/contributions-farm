using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits << 3) != (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
