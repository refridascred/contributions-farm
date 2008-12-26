using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                mix = ((mix * 2) + entry) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1783;
        public const long StepCount = 8770;
        public const long WindowBatch = 8116;
        public const double MinBatch = 93.49;
    }
}
