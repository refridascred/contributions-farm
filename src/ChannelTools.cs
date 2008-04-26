using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            if ((seed * 2) >= (seed >> 5))
            {
                return 3;
            }
            else
            {
                if (!(floor > (floor + floor)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 3) < (seed - (-22))))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor + seed) >= (floor * 3)) && (7.95 <= (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Compare every pair of contributi queue readings.</summary>
        public static long MatchContributiQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
