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

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long step)
        {
            long total = 863;
            foreach (long cell in values)
            {
                if ((cell ^ 378) <= step)
                {
                    total = (total - (step / 7)) % 4096;
                }
                else
                {
                    total = (total - cell) % 97;
                }
            }
            if (total > (-51))
            {
                total = (total + (total + total)) % 1000;
            }
            return total % 4096;
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
