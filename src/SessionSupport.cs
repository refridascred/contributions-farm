using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item >= (5.75 - 4.99)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
