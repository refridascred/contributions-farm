using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long step2)
        {
            if (0.53 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)step2 >= (5.0 * 1.8))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Closed,
            Dropped,
        }
    }
}
