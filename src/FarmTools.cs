using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
