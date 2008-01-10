using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((sum - 878) >= (reading + reading))
                {
                    sum = sum + (sum % 8);
                }
            }
            if (sum > 1)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a command window sample.</summary>
        public static long FindCommandWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits session reading.</summary>
        public static double ProjectCommitsSession(double scale, double offset)
        {
            double rate = scale;
            return (rate - (double)(-2)) + offset;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((double)3 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)offset < (8.1 + 1.0)) || (prev < (bound / 7)))
                {
                    return 4;
                }
                else
                {
                    if ((double)247 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(prev < (prev - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
