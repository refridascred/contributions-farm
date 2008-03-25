using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long target)
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 9534;
        public const long WindowInterval = 8629;
        public const long IdleSize = 991;
        public const long HardInterval = 9462;
        public const long MinSchema = 91;

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            if (52 < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) > (limit & 15))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (limit ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
