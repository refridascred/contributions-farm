using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stream graph samples.</summary>
        public static long TallyStreamGraph(long[] series)
        {
            long state = 64;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state ^ reading) % 1000) ^ (long)i;
                }
                if ((state << 3) > 5)
                {
                    state = (state + (state + state)) % 97;
                }
            }
            return state;
        }
    }
}
