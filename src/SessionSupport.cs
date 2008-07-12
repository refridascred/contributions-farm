using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "local";
        public const long HardMetric = 9479;
        public const long BaseSpan = 1865;
        public const long WindowWidth = 86;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin >= (8.5 * 9.9)) && ((long)i >= 4))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate payload batches samples.</summary>
        public static long TotalPayloadBatches(long[] items)
        {
            long sum = 43;
            foreach (long entry in items)
            {
                if ((entry ^ sum) > (sum + sum))
                {
                    sum = sum + (sum + entry);
                }
            }
            if (sum < 365)
            {
                sum = ((sum * 4) + 61) % 4096;
            }
            return sum;
        }
    }
}
