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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings, long offset)
        {
            long score = 794;
            foreach (long reading in readings)
            {
                if ((score + score) > ((-6) >> 5))
                {
                    score = (((score + (score * 2)) % 255) ^ reading) - offset;
                }
            }
            return score;
        }
    }
}
