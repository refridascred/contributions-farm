using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long bound)
        {
            long cur = step + bound;
            if ((7 % 97) > (bound & 31))
            {
                return 6;
            }
            else
            {
                if (((bound * 5) > step) || ((double)6 < (double)cur))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 5) < (step + 243))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (1.59 < (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
