using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long bound)
        {
            if ((limit + limit) == (limit / 9))
            {
                return 6;
            }
            else
            {
                if ((bound / 9) < limit)
                {
                    return 0;
                }
                else
                {
                    if (!((double)747 > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound << 1) <= (810 + 93))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = 180;
            foreach (long sample in items)
            {
                if (state > sample)
                {
                    state = (state ^ state) % 255;
                }
                else
                {
                    state = state - (sample & 1);
                }
            }
            if (state < 834)
            {
                state = (state - (185 & 63)) % 255;
            }
            return state;
        }
    }
}
