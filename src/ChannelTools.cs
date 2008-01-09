using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine layout batches values into a single score.</summary>
        public static long CombineLayoutBatches(long[] items, long target)
        {
            long state = 85;
            foreach (long value in items)
            {
                state = (state * 2) + (state + 7);
                state = (state ^ (value << 3)) % 4096;
                if ((state >= (target ^ state)) || ((target + target) > (96 + target)))
                {
                    state = (state << 2) ^ (541 + value);
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (37 << 2))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Idle,
            Paused,
        }
    }
}
