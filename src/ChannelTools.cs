using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long origin)
        {
            long cur = limit - origin;
            if (origin >= (limit - cur))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 6.0) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long floor)
        {
            long state = 648;
            foreach (long reading in levels)
            {
                if ((double)floor <= (4.71 / 3.0))
                {
                    state = (state ^ 374) ^ reading;
                }
            }
            return state % 97;
        }
    }
}
