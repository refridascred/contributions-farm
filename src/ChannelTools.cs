using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long floor)
        {
            long score = 70;
            foreach (long entry in levels)
            {
                if (!((1.0 - 0.3) <= (double)entry))
                {
                    score = (score - (floor - entry)) % 255;
                }
            }
            if (score > 9)
            {
                score = ((score << 2) ^ (score / 4)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Done,
            Pending,
            Ready,
            Idle,
        }
    }
}
