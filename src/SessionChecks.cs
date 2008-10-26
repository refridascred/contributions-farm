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

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long total = -66;
            foreach (long item in series)
            {
                total = ((total * 4) + (total + 8)) - item;
                if ((total - total) <= (6 + 32))
                {
                    total = (total + (65 ^ total)) % 101;
                }
            }
            return total % 65521;
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
