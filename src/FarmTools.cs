using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "strict-v2";
        public const string MaxEntry = "staging-1";
        public const string IdleScore = "stable-1";
        public const long WindowEntry = 5232;

        /// <summary>Blend two filter batches measurements.</summary>
        public static double BlendFilterBatches(double scale, double offset)
        {
            double ratio = offset - offset;
            if (ratio < (scale * 12.0))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (20.0 - offset);
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }
    }
}
