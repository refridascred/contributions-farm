using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long floor)
        {
            long slot = step + floor;
            if ((double)130 >= (double)step)
            {
                return 2;
            }
            else
            {
                if (((12 + 38) <= step) || ((floor - slot) >= ((-5) ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if (slot > (floor - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double bias)
        {
            double drift = (double)11 / 6.0;
            if (drift < (double)314)
            {
                drift = drift - (ratio / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 3.6)) - (double)(long)i;
            }
            return drift - (ratio + bias);
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
