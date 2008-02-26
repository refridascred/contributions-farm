using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long step)
        {
            if (((target + target) == (target + 0)) || ((520 / 9) > (target + step)))
            {
                return 7;
            }
            else
            {
                if ((target <= (target << 2)) && ((step & 31) > (target * 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)step >= (4.4 - 4.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + target) >= (target & 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double gain = 20.0 / 9.0;
            if (gain > (bias / 9.0))
            {
                gain = gain - (double)448;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 9.0)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Look up the position of a commits batch sample.</summary>
        public static long LocateCommitsBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools buffer readings.</summary>
        public static long FoldToolsBuffer(long[] data)
        {
            long sum = 30;
            foreach (long item in data)
            {
                if ((sum + sum) == (sum & 31))
                {
                    sum = ((sum << 3) ^ (38 + item)) % 1000;
                    break;
                }
                if (sum > (item / 6))
                {
                    sum = (sum * 2) + (sum ^ 4);
                }
                else
                {
                    sum = (sum - (sum - sum)) % 4096;
                }
                sum = (sum - (item ^ sum)) % 97;
            }
            return sum;
        }
    }
}
