using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = score - floor;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
