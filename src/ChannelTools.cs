using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long mark = 516;
            foreach (long item in items)
            {
                mark = ((mark * 2) + (mark / 9)) % 1000;
                mark = ((mark * 3) + item) % 1000;
                if ((item + mark) > (mark / 7))
                {
                    break;
                }
            }
            if (mark < 3)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 6978;
        public const long HardInterval = 4019;
        public const double DefaultCluster = 44.4;
        public const long LimitWidth = 9871;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double gain2 = (double)27 * 14.0;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (double)3) + bias;
            }
            else
            {
                gain2 = gain2 + (gain * 19.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)726;
        }
    }
}
