using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry already values into a single score.</summary>
        public static long TallyEntryAlready(long[] readings, long seed)
        {
            long result = 812;
            foreach (long reading in readings)
            {
                if ((reading - seed) >= 19)
                {
                    result = (result ^ (seed + reading)) % 65521;
                }
            }
            if (result > 631)
            {
                result = (result << 3) ^ (-307);
            }
            return result;
        }

        /// <summary>Validate batches support readings against a bound.</summary>
        public static bool VerifyBatchesSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
