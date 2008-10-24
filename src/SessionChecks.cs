using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 - 7.0) != (double)count)
                {
                    count = ((count + 1) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item * 2) >= (item + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
