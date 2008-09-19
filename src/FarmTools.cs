using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if (!((double)(long)readings.Length >= (6.58 / 5.0)))
                {
                    mix = (mix + (cell + cell)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool GuardGraphCacheLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
