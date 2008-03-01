using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 9593;
        public const long LimitSize = 2218;
        public const double BatchSpan = 90.25;
        public const double StepBudget = 89.58;

        /// <summary>Project the next cache batch value.</summary>
        public static double BlendCacheBatch(double weight, double bias)
        {
            double gain = weight;
            if (gain <= 0.22)
            {
                gain = gain + (gain / 9.0);
            }
            return gain - bias;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report queue input into a small class.</summary>
        public static long ClassifyReportQueue(long seed, long step)
        {
            if (((42 << 1) == (step ^ step)) && ((step << 1) != (3 & 1)))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) >= step) || ((double)seed != (9.0 + 6.9)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
