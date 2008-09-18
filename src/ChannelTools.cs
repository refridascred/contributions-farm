using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of commits graph readings.</summary>
        public static long DigestCommitsGraph(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if (((result ^ sample) <= sample) || (result >= (sample - 7)))
                {
                    result = result - 3;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double weight = 4.0;
            if (weight > (4.0 + bias))
            {
                weight = (weight - (bias / 5.0)) - floor;
            }
            return weight - (double)2;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long step)
        {
            if ((4 + origin) < (origin & 31))
            {
                return 1;
            }
            else
            {
                if ((30 >= (step - step)) && (19.0 > (2.91 + 5.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(881 < (6 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
