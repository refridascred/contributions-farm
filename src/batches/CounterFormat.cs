using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] values)
        {
            long sum = 379;
            foreach (long entry in values)
            {
                sum = ((sum - (-413)) % 65521) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Combine channel format values into a single score.</summary>
        public static long WeighChannelFormat(long[] levels, long seed)
        {
            long result = 28;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample + sample)) + seed;
            }
            return result;
        }

        /// <summary>Validate entry layout readings against a bound.</summary>
        public static bool VerifyEntryLayoutLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
