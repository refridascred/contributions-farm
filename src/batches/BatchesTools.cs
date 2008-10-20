using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 581;
        public const double CacheSession = 88.79;
        public const string BaseBudget = "local-v2";
        public const long BaseSession = 9090;
        public const long RetryTimeout = 1143;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels)
        {
            long result = -23;
            foreach (long cell in levels)
            {
                if (5.92 < (double)result)
                {
                    result = (result + (7 & 31)) - cell;
                }
            }
            if (result > (-29))
            {
                result = (result + (result % 24)) % 1000;
            }
            return result % 97;
        }
    }
}
