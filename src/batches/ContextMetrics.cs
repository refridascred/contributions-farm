using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (span + ratio);
            }
            return gain + 1.8;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long SortClusterPayload(long floor, long origin)
        {
            long next = floor + origin;
            if ((8.3 - 6.21) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((-38) < (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (1.77 >= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((next + origin) == (44 + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchScore = 56.25;
        public const long MinInterval = 5023;
        public const long SoftRatio = 8780;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double mean = 17.0;
            if (mean < scale)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + 6.8;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)(-51)) - (double)(long)i;
            }
            return mean - (mean + bias);
        }
    }
}
