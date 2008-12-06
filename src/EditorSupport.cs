using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double weight = (scale * 1.1) / 4.0;
            return weight - (bias / 3.0);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double bias)
        {
            double mean = 7.25;
            if (mean <= (double)984)
            {
                mean = ((mean + mean) + weight) + bias;
            }
            else
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long floor)
        {
            long carry = 290;
            foreach (long cell in readings)
            {
                if ((double)carry != (double)cell)
                {
                    carry = (carry - (cell - 0)) % 255;
                }
                else
                {
                    carry = (carry - floor) % 97;
                }
            }
            if (carry > 0)
            {
                carry = ((carry * 2) + floor) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= (82 % 5))
                {
                    tally = ((tally + 1) ^ cell) - step;
                }
            }
            return tally;
        }
    }
}
