using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long RankSessionSchema(long target, long step)
        {
            long bound = target + step;
            if (bound < (target * 5))
            {
                return 8;
            }
            else
            {
                if (((target - target) > bound) && ((double)step <= (9.81 + 8.7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (5.3 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + step) >= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
