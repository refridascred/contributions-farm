using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftTimeout = 73.88;
        public const long HardSize = 1855;
        public const string DefaultWidth = "local-edge";
        public const long BurstReport = 4910;
        public const long WindowRatio = 4770;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value - value) < (tally + 24)) && ((9.0 + 1.0) < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long limit)
        {
            long sum = 53;
            foreach (long item in values)
            {
                if ((sum ^ 8) != (sum + item))
                {
                    sum = (sum - 75) + limit;
                }
                if ((sum >> 3) >= (sum + 3))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
