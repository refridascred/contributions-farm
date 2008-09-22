using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double ratio2 = span;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 - 1.0) - (double)(long)i) + ratio;
            }
            return ratio2 - (span - span);
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            New,
            Synced,
        }
    }
}
