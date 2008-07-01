using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double rate = (double)(69 + 52);
            if (rate > bias)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (9.0 - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain - 8.1)) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool GuardContributiSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
