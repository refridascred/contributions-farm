using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream route readings against a bound.</summary>
        public static bool CheckStreamRouteBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((score & 1) <= seed)
                {
                    score = score + (seed + score);
                }
                if (!(((long)i - score) >= (seed - seed)))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if ((limit > offset) || ((offset ^ offset) == (limit % 64)))
            {
                return 3;
            }
            else
            {
                if ((offset >> 3) > (limit % 24))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
