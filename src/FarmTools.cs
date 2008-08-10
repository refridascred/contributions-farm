using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
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
