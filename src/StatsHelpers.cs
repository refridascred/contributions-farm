using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Match up checks batch samples.</summary>
        public static long MatchChecksBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank queue counter input into a small class.</summary>
        public static long RankQueueCounter(long seed, long offset)
        {
            long edge = seed - offset;
            if ((seed + 136) > (edge - seed))
            {
                return 6;
            }
            else
            {
                if (19.0 >= (double)edge)
                {
                    return 5;
                }
                else
                {
                    if ((seed >= (seed - offset)) || (0.87 < (double)edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed > (17.0 * 9.1)) && ((edge & 31) == (edge * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Idle,
            Closed,
            Synced,
            Dropped,
        }
    }
}
