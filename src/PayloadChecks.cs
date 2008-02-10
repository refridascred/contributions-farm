using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double load = floor - (double)920;
            if (load < rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + load)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count == (5.86 * 2.1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 78.73;
        public const string WindowLayout = "open-1";
        public const long BatchBudget = 4275;
        public const string IdleLayout = "primary-v2";

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long carry = 369;
            foreach (long value in levels)
            {
                carry = carry - (value + value);
            }
            return carry % 4096;
        }
    }
}
