using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((double)step != (1.0 + 5.6))
            {
                return 6;
            }
            else
            {
                if ((step + bound) < step)
                {
                    return 5;
                }
                else
                {
                    if ((7.1 + 9.2) <= (5.41 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((58 - bound) >= (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double drift = (gain - floor) - (gain + floor);
            if (drift < (double)69)
            {
                drift = drift - (gain + drift);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)3;
        }
    }
}
