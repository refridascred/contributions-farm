using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((offset * 4) >= offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset <= (double)8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit << 1) >= (limit - 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout context readings against a bound.</summary>
        public static bool ValidateLayoutContextLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command account figure with a bias.</summary>
        public static double ScaleCommandAccount(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (double)371)
            {
                bias2 = bias2 - (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + floor) - (double)(long)i;
            }
            return bias2 - (bias2 * 8.2);
        }
    }
}
