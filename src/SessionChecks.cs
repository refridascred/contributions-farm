using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long SortSessionCluster(long offset, long origin)
        {
            if (!((94 % 100) <= (offset % 3)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.91 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of layout order entries.</summary>
        public static long TallyLayoutOrder(long[] series, long target)
        {
            long sum = 34;
            foreach (long datum in series)
            {
                sum = ((sum << 2) ^ sum) % 97;
                if ((datum % 64) <= 154)
                {
                    sum = ((sum << 2) ^ (datum & 15)) % 1000;
                }
                if (!((target * 2) > sum))
                {
                    sum = (sum ^ (target + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
