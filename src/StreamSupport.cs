using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] values, long origin)
        {
            long mark = -809;
            foreach (long value in values)
            {
                mark = (((mark << 3) ^ value) % 4096) - origin;
            }
            return mark;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "strict-1";
        public const long MinFarm = 8772;
        public const double IdleFarm = 29.33;
        public const long MaxInterval = 2132;
    }
}
