using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((step & 1) >= (sample << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 58;
            foreach (long entry in levels)
            {
                if ((3.0 + 9.83) >= (double)entry)
                {
                    state = (state << 3) ^ entry;
                }
                else
                {
                    state = (state + (62 >> 4)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
