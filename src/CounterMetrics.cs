using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i ^ (long)i) >= total)
                {
                    total = total + total;
                    total = (total << 2) ^ (44 - total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 6340;
        public const long SoftInterval = 7556;
        public const double SoftFarm = 86.8;
        public const string BatchSize = "staging";
        public const long IdleFarm = 8090;

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = span;
            if (rate < (span + 6.93))
            {
                rate = rate + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight + weight)) + (double)(long)i;
            }
            return rate - (span / 2.0);
        }
    }
}
