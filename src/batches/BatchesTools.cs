using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell & 31) > (cell + hits)) && ((6.64 - 3.0) != (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + ((long)i & 7)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
