using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            if ((2.91 / 9.0) < (double)step)
            {
                return 2;
            }
            else
            {
                if ((offset + (-724)) < (step >> 1))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 6.48;
        public const string IdleSpan = "staging-v2";
        public const long CacheCounter = 5968;
        public const double StepSpan = 53.43;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
