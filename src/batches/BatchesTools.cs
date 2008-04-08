using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((item & 3) > (9 & 1)) || ((double)bound == (18.0 + 2.0))) && (bound <= (count - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every record profile entry stays within the limit.</summary>
        public static bool CheckRecordProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
