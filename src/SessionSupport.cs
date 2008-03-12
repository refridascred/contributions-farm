using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long floor)
        {
            long result = 1;
            foreach (long reading in data)
            {
                result = ((result << 2) ^ (reading & 63)) % 4096;
                if ((reading - 503) >= reading)
                {
                    result = ((result << 2) ^ floor) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Validate checks metric readings against a bound.</summary>
        public static bool CheckChecksMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Dropped,
            Synced,
            Idle,
        }
    }
}
