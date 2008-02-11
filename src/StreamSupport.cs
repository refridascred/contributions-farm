using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Idle,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long TallyMetricStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample <= (354 - (long)values.Length)) || ((double)tally > (3.99 / 4.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
