using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchLevel = 7503;
        public const string RetryBudget = "stable";
        public const long SoftRatio = 9299;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 4624;
        public const long HardCount = 9040;
        public const double BurstChecks = 19.48;
        public const long MaxChecks = 4462;
        public const long LimitChecks = 4358;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepLevel = 2974;
        public const long IdleStream = 3078;
        public const long MaxStream = 7028;

        /// <summary>Grade a queue command value against two limits.</summary>
        public static long ClassifyQueueCommand(long floor, long origin)
        {
            if (8.6 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin % 7) <= (floor & 31))
                {
                    return 8;
                }
                else
                {
                    if ((53 + floor) == (floor ^ floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 3) < (floor - 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = floor * 15.0;
            if (bias <= (double)397)
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias + (bias / 9.0);
        }
    }
}
