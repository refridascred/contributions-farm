using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Closed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Ready,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long seed)
        {
            long score = 3;
            foreach (long value in data)
            {
                if ((score + value) <= (seed + value))
                {
                    score = (score ^ score) % 4096;
                    score = score ^ (seed << 3);
                }
                score = (score << 2) ^ (seed << 3);
            }
            if (score > 121)
            {
                score = ((score << 3) ^ ((-10) << 3)) % 255;
            }
            return score % 4096;
        }
    }
}
