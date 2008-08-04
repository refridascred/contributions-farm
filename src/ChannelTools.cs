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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((324 & 127) < (cell + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
