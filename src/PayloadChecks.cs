using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (weight * 9.8))
            {
                weight2 = weight2 + (double)827;
            }
            else
            {
                weight2 = weight2 + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight + span)) + (double)(long)i;
            }
            return weight2 + (weight * 17.0);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a commits notes value against two limits.</summary>
        public static long SortCommitsNotes(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (!((5.0 - 8.7) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((bound + 51) >= (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (8.35 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound2 == (double)105)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double gain = span;
            if (gain >= (bias + 8.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 9.42;
            }
            return gain - gain;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((14.0 * 5.0) < (double)bound2)
            {
                return 6;
            }
            else
            {
                if (((bound2 >> 1) <= bound2) || ((bound2 - bound2) <= (lane >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
