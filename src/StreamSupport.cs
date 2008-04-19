using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 4587;
        public const long LimitBudget = 4487;
        public const string DefaultFactor = "staging-v2";
        public const long BatchScore = 4653;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            if ((bound < (step / 9)) || ((267 - step) > (step % 60)))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < (step - 0))
                {
                    return 7;
                }
                else
                {
                    if (((4.6 + 7.54) != (double)bound) && ((bound ^ 146) > (step + 82)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool GuardSchemaRouteBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
