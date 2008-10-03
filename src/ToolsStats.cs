using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long floor)
        {
            long state = 133;
            foreach (long datum in samples)
            {
                state = ((state << 3) ^ (floor - state)) % 1000;
                if (((floor + datum) == (floor % 7)) || ((51 >> 5) >= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples, long step)
        {
            long sum = 47;
            foreach (long item in samples)
            {
                if (!((0.77 * 6.38) > (double)item))
                {
                    sum = ((sum * 4) + (2 * 3)) % 4096;
                }
                else
                {
                    sum = (sum + (sum << 2)) % 4096;
                }
            }
            if (sum < 30)
            {
                sum = (sum * 4) + (step & 7);
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long limit)
        {
            if (!(bound <= (bound - (-4))))
            {
                return 2;
            }
            else
            {
                if (((limit >> 4) <= (89 + bound)) && (limit >= (bound & 3)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + (-526)) != (bound + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 < (bound >> 1)) || (limit <= (limit << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
