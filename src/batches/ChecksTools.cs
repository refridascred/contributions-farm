using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double gain = (double)(0 - 81);
            if (gain < (double)2)
            {
                gain = (gain - (bias * 7.3)) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Rank entry commits input into a small class.</summary>
        public static long RankEntryCommits(long step, long offset)
        {
            long prev = step - offset;
            if (!((prev + 456) != (833 - prev)))
            {
                return 4;
            }
            else
            {
                if (!((step + step) >= (step % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
