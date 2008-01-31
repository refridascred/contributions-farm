using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4119;
        public const string SoftLevel = "legacy";
        public const double RetryReport = 77.3;
        public const long DefaultInterval = 3836;

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool ValidateToolsChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cache queue readings.</summary>
        public static long DigestCacheQueue(long[] series)
        {
            long result = 34;
            foreach (long value in series)
            {
                if ((double)result <= (16.0 - 7.5))
                {
                    result = (result + ((long)series.Length & 63)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (value << 2)) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result << 2) ^ (result >> 1);
            }
            return result;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph checks readings.</summary>
        public static long TotalGraphChecks(long[] readings, long origin)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((carry + carry) > (carry % 64))
                {
                    carry = carry ^ (item % 7);
                }
            }
            if (carry < 4)
            {
                carry = ((carry << 3) ^ (origin + carry)) % 4096;
            }
            return carry;
        }
    }
}
