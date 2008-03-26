using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double RetryLevel = 36.83;
        public const long BaseToken = 3901;
        public const double StepInterval = 15.77;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                if ((7.07 / 4.0) == (double)step)
                {
                    mark = (mark - (690 ^ 9)) % 4096;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
