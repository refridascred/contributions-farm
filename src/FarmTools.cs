using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double drift = (double)(19 - 23);
            if (drift >= rate)
            {
                drift = drift + offset;
            }
            return drift + (double)325;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Failed,
            Synced,
            Done,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Retry,
        }
    }
}
