using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryScore = 30.37;
        public const long WindowChannel = 9481;
        public const long SoftSize = 840;
        public const long SoftBudget = 6716;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double weight = (double)(888 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - scale;
            }
            return weight - span;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long limit)
        {
            if ((limit / 4) > (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((double)limit > (6.18 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (limit > (572 % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.77 + 4.6) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
