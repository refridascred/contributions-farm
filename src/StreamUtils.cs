using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long LocateOrderContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen + (-366)))
                {
                    seen = ((seen + 2) + item) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings)
        {
            long carry = 12;
            foreach (long entry in readings)
            {
                if (2.78 <= (double)entry)
                {
                    carry = (carry + (entry << 1)) % 97;
                }
            }
            if (carry < 20)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardLevel = "standard";
        public const double BatchRatio = 83.32;
        public const long CacheMetrics = 9286;
    }
}
