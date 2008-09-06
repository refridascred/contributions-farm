using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long origin)
        {
            long delta = offset ^ origin;
            if ((9 + offset) > 644)
            {
                return 0;
            }
            else
            {
                if (offset < delta)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            New,
            Locked,
            Synced,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
