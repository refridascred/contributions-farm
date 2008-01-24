using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowInterval = 9738;
        public const long HardSession = 6904;
        public const double RetrySession = 80.12;
        public const long WindowSession = 1619;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((step & 1) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((step / 4) >= (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 3451;
        public const long HardGraph = 2166;
        public const long DefaultGraph = 8788;
        public const long StepGraph = 3276;
        public const long RetrySize = 1336;

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double bias3 = bias + (double)5;
            if (bias3 < (bias2 + 13.0))
            {
                bias3 = bias3 - (bias2 / 9.0);
            }
            else
            {
                bias3 = bias3 + bias3;
            }
            return bias3 + (bias * 4.95);
        }
    }
}
