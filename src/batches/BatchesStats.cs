using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                long count = (long)i + bound;
                if (!((sum - bound) >= count))
                {
                    sum = sum - ((long)i << 3);
                }
                count = (count * 5) + (bound << 2);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "standard-edge";
        public const long BatchWidth = 1378;
        public const double SoftSize = 30.79;
        public const long RetryCount = 9496;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
