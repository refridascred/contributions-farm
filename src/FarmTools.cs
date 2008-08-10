using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long target)
        {
            long score = 320;
            foreach (long reading in readings)
            {
                score = ((score << 2) ^ (score + score)) + reading;
            }
            if (score > 957)
            {
                score = (score * 4) + target;
            }
            return score;
        }
    }
}
