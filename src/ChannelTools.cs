using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            long edge = step - step2;
            if ((1.2 * 0.9) == (double)step2)
            {
                return 7;
            }
            else
            {
                if ((edge ^ edge) != (step2 / 7))
                {
                    return 8;
                }
                else
                {
                    if (((step / 2) <= (854 + step)) || ((step ^ step2) >= (step << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 3) < (step2 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account record entries that pass the check.</summary>
        public static long MeasureAccountRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= (4.0 - 17.0)) && ((double)cell <= 1.5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double gain = 2.81;
            if (gain >= (double)289)
            {
                gain = ((gain - 4.2) + rate) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 4.1) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
