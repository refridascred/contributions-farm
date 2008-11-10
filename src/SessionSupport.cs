using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((1.0 / 2.0) > (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count << 3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
