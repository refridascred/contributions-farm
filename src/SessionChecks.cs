using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up context profile samples.</summary>
        public static long MatchContextProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double gain = 3.0;
            if (gain > (gain + 2.0))
            {
                gain = ((gain + gain) - bias) - floor;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain - (double)365;
        }

        /// <summary>Adjust a already buffer reading.</summary>
        public static double ProjectAlreadyBuffer(double weight, double floor)
        {
            double bias = (double)(5 << 3);
            if (bias >= (bias - weight))
            {
                bias = bias + weight;
            }
            return bias + (floor - floor);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long bound)
        {
            if (!((step + step) <= (step / 6)))
            {
                return 5;
            }
            else
            {
                if ((bound ^ 339) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 7) != (step ^ 672))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step < (4.44 / 8.0))
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
