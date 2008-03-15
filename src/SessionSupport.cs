using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long ClassifySchemaCounter(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (4.1 > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((floor > (delta + floor)) && ((0.2 / 6.0) >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (47 <= (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= delta) || ((double)delta < (8.57 - 2.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((score << 2) >= score))
                {
                    score = score - (8 >> 2);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long floor, long step)
        {
            if (!((step + step) <= (floor * 2)))
            {
                return 1;
            }
            else
            {
                if ((double)floor > (double)step)
                {
                    return 4;
                }
                else
                {
                    if (!((86 - floor) <= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
