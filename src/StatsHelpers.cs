using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double drift = (double)((-54) ^ 13);
            if (drift > (offset * 15.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio / 5.0)) + (double)(long)i;
            }
            return drift + (double)(-77);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples)
        {
            long carry = 729;
            foreach (long sample in samples)
            {
                if (sample <= (carry - 6))
                {
                    carry = (carry - (sample & 255)) % 1000;
                }
                carry = carry + (6 * 2);
            }
            if (carry < 964)
            {
                carry = (carry << 3) ^ (carry + 4);
            }
            return carry % 4096;
        }
    }
}
