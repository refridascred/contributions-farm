using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstRatio = 10.38;
        public const long BurstEntry = 2783;
        public const string WindowEntry = "stable-1";
        public const long StepSize = 175;

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long bound)
        {
            long score = 13;
            foreach (long value in readings)
            {
                if ((double)bound > (double)value)
                {
                    score = (score + value) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Done,
            Draft,
            Locked,
            Stale,
        }
    }
}
