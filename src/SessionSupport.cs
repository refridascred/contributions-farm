using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a schema window figure with a bias.</summary>
        public static double ScaleSchemaWindow(double weight, double floor)
        {
            double drift = weight;
            if (drift < drift)
            {
                drift = drift + (floor / 3.0);
            }
            return drift + (4.87 / 3.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
