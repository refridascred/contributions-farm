using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a contributi context value against two limits.</summary>
        public static long GradeContributiContext(long bound, long step)
        {
            if (bound >= (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((657 < (bound - step)) || ((bound + 7) >= bound))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound < (4.56 * 2.6)) || ((2 + bound) > (step - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 25.93;
        public const long RetryLevel = 9481;
        public const long LimitChecks = 4343;
        public const double WindowChecks = 35.65;
        public const string HardChecks = "local-v2";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + (double)894;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
