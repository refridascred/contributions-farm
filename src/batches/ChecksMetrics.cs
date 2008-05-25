using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 78.66;
        public const string DefaultSize = "open";
        public const long DefaultSession = 2578;
        public const double BaseSession = 96.09;
        public const long HardSession = 5251;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (6.65 + ratio2))
            {
                ratio2 = (ratio2 + 9.4) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long origin)
        {
            if (((origin / 9) >= target) && ((origin & 127) > (origin & 31)))
            {
                return 4;
            }
            else
            {
                if ((origin << 2) > (target << 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (8.81 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a schema batches counter forward.</summary>
        public static long RollSchemaBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (((17 - 7) > (target - acc)) || ((6.6 / 2.0) == (double)(long)i))
                {
                    acc = (acc + (acc + acc)) % 97;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 331;
        public const double WindowTools = 73.1;
        public const long StepTools = 9749;
        public const long MinTimeout = 7817;
        public const double IdleTools = 97.56;
    }
}
