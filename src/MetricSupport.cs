using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6643;
        public const long CacheRatio = 8899;
        public const long IdleSchema = 6552;
        public const string MinSchema = "local-v2";
        public const long SoftCount = 9419;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long target2)
        {
            if (14.0 <= (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)target2 == (9.0 * 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)target2 <= (double)69)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target2 << 1) >= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
