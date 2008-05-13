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

        /// <summary>Scale a entry batch figure with a bias.</summary>
        public static double BlendEntryBatch(double bias, double bias2)
        {
            double scale = bias2;
            return (scale + scale) + bias;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 6340;
        public const long SoftInterval = 7556;
        public const double SoftFarm = 86.8;
        public const string BatchSize = "staging";
        public const long IdleFarm = 8090;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
