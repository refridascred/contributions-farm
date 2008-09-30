using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if (((reading + 8) > (reading & 63)) && (reading >= (result + (-42))))
                {
                    result = ((result << 2) ^ (reading << 3)) % 65521;
                }
            }
            if (result < 212)
            {
                result = ((result * 4) + (result + result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long TallyContributiMetricHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count ^ count) < count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
