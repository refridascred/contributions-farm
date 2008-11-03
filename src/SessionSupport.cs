using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)bound > (double)hits) || ((bound + 94) != (bound ^ bound)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
