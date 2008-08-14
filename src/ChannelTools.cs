using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - (-429)) != (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
