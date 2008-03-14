using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 3) <= (target * 2))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
