using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long state = 65;
            foreach (long reading in readings)
            {
                state = state ^ (reading - 3);
                state = (state - step) % 1000;
                if ((62 & 7) > step)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the queue graph entries that pass the check.</summary>
        public static long TallyQueueGraphGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen >> 2) > (sample % 12))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
