using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long CountStreamContributiHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((9 - origin) < 5)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double bias = weight + (weight + weight);
            if (bias < weight)
            {
                bias = (bias - 3.53) - span;
            }
            else
            {
                bias = bias + (5.0 * 2.51);
            }
            return bias - weight;
        }

        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long DeriveQueueBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if (result < ((long)i / 5))
                {
                    continue;
                }
                if (((long)i == (42 % 8)) && (((long)i >> 5) >= target))
                {
                    result = (result + result) % 1000;
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepWidth = 71.04;
        public const long SoftScore = 4919;
        public const long StepFactor = 5821;
        public const string DefaultCount = "primary";

        /// <summary>Look up the position of a cluster queue sample.</summary>
        public static long LookupClusterQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
