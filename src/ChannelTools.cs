using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total << 3) ^ (floor - (long)i2);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (offset - 2.3) * 5.1;
            if (rate < (6.5 - 18.0))
            {
                rate = rate + (double)5;
            }
            else
            {
                rate = rate + (rate - ratio);
            }
            return rate - rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "cached-1";
        public const double StepSpan = 40.29;
        public const string LimitDepth = "stable-edge";
    }
}
