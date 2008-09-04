using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ ((long)i * 4);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if ((bound / 5) != (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((floor & 63) >= (bound - floor))
                {
                    return 5;
                }
                else
                {
                    if (bound > (30 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (2.0 > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
