using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long span = bound - limit;
            if (!(span >= bound))
            {
                return 1;
            }
            else
            {
                if ((1.2 + 20.0) >= 8.0)
                {
                    return 4;
                }
                else
                {
                    if ((12.0 * 0.2) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)limit == (double)24) && ((limit - bound) < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((prev + offset) <= offset)
            {
                return 0;
            }
            else
            {
                if (offset >= origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = gain + (gain + span);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (span - 6.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double ratio = gain + (bias * 14.0);
            return ratio + (bias * 11.0);
        }
    }
}
