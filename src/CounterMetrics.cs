using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 170;
        public const string BatchBatches = "latest";
        public const long IdleCount = 592;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double gain = (double)((-8) * 5);
            if (gain >= (double)82)
            {
                gain = (gain - (double)8) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (6.8 * 15.0)) - (double)(long)i;
            }
            return gain - bias2;
        }
    }
}
