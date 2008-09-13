using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a command cluster value against two limits.</summary>
        public static long RankCommandCluster(long bound, long offset)
        {
            if (!((4.0 - 12.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset - 4))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (bound - 159))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15 >= (tally << 1)) || ((tally < (5 + 783)) || ((value + tally) >= (value + value))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
