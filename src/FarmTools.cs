using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double gain = (double)(72 % 7);
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (ratio - bias);
            }
            return gain + (gain - gain);
        }
    }
}
