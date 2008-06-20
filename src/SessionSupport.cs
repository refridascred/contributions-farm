using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ limit) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
