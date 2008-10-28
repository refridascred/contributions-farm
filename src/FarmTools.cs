using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
