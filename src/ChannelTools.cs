using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache graph samples.</summary>
        public static long ScoreCacheGraph(long[] items, long step)
        {
            long anchor = 0;
            foreach (long value in items)
            {
                anchor = (anchor - (value / 6)) % 97;
            }
            if (anchor < 836)
            {
                anchor = (anchor ^ (step ^ anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Synced,
            Ready,
        }
    }
}
