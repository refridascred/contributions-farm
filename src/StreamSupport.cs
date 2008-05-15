using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Dropped,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if (sample >= (47 - score))
                {
                    score = (score ^ (sample % 8)) % 255;
                }
                else
                {
                    score = (score ^ (score >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
