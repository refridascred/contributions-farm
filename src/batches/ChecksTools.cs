using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Validate record format readings against a bound.</summary>
        public static bool CheckRecordFormatBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (bound >= (bound % 10))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine account contributi values into a single score.</summary>
        public static long TotalAccountContributi(long[] series)
        {
            long sum = 855;
            foreach (long entry in series)
            {
                if (((double)entry <= (7.2 / 2.0)) && ((entry + entry) >= sum))
                {
                    sum = ((sum << 2) ^ 9) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
