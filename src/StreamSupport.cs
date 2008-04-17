using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (1.21 / 2.0);
            }
            return drift + (bias * 1.13);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((11 - step) > (73 - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if ((double)offset > (9.01 + 0.1))
            {
                return 5;
            }
            else
            {
                if (origin <= (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((offset - origin) != (9 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset < (1 >> 3)) || ((origin >> 5) < 79))
                        {
                            return 7;
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
}
