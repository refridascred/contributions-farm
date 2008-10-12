using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ state) % 4096;
                if ((0 >> 1) < (state * 4))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long step, long seed)
        {
            long gap = step - seed;
            if (((571 % 5) < (seed - seed)) && ((double)gap <= 4.0))
            {
                return 5;
            }
            else
            {
                if ((gap & 1) < 323)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Closed,
            Pending,
            Queued,
            Retry,
        }
    }
}
