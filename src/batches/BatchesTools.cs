using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double rate = (double)(9 - 89);
            if (rate <= (double)8)
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (span / 5.0)) + (double)(long)i;
            }
            return rate + 4.0;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long step)
        {
            long slot = bound + step;
            if (((step + bound) <= (7 % 60)) || (step > (slot - slot)))
            {
                return 5;
            }
            else
            {
                if ((57 - slot) < (bound << 1))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 8) >= (step >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (slot < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
