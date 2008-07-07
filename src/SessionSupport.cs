using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double mean = 2.94;
            if (mean >= (double)513)
            {
                mean = ((mean - mean) - ratio) + span;
            }
            return mean + 5.76;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long SeekCommandPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long delta = floor - limit;
            if (((floor / 4) == (delta ^ limit)) || ((6.21 * 4.7) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (double)delta) || ((1.0 + 5.0) > (double)delta))
                {
                    return 8;
                }
                else
                {
                    if ((56 <= (limit & 1)) && ((limit % 10) == (floor & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)delta <= (4.38 + 13.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
