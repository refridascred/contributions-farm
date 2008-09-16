using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + 3.8) + weight;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long score = 22;
            foreach (long cell in readings)
            {
                if ((0.57 - 13.0) != (double)cell)
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (score & 3);
                }
                if ((double)9 == (double)score)
                {
                    score = (score - (cell + 27)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (score << 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
