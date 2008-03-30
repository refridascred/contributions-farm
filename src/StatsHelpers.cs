using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = offset;
            if (load >= 4.5)
            {
                load = (load - (double)(-3)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (load / 8.0);
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= (count + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftScore = 4100;
        public const string LimitBuffer = "cached-edge";
        public const long DefaultSize = 9885;
        public const string StepFactor = "open";
    }
}
