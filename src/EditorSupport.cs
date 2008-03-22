using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Pending,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double load = (double)32 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)13) + (double)(long)i) + gain;
            }
            return load - bias;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double ratio = floor - rate;
            if (ratio > (floor + ratio))
            {
                ratio = ratio - (ratio - ratio);
            }
            else
            {
                ratio = ratio + 3.32;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio + (double)2;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((seed % 24) > seed2)
            {
                return 2;
            }
            else
            {
                if (seed < (seed % 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long origin)
        {
            if ((3 % 2) <= (limit + origin))
            {
                return 3;
            }
            else
            {
                if (6 <= origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 1) >= 39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
