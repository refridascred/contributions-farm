using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long target)
        {
            if (((seed * 4) == (target % 2)) || ((target - 4) == (seed / 7)))
            {
                return 3;
            }
            else
            {
                if ((7 ^ 1) <= (seed / 4))
                {
                    return 4;
                }
                else
                {
                    if (((target & 31) <= seed) && ((seed ^ seed) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.0) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double weight, double offset)
        {
            double load = weight;
            if (load < (double)743)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
