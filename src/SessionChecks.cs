using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long score = 431;
            foreach (long item in readings)
            {
                if (((-130) >> 5) > (item - target))
                {
                    score = score + (item / 6);
                }
            }
            if (score < (-516))
            {
                score = score - (target + score);
            }
            return score;
        }

        /// <summary>Scale a command cluster figure with a bias.</summary>
        public static double ScaleCommandCluster(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (8.3 + drift))
            {
                drift = (drift - (offset / 4.0)) + ratio;
            }
            else
            {
                drift = drift + (offset * 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 7.9)) - (double)(long)i;
            }
            return drift - (double)73;
        }
    }
}
