using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally << 2) < entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool GuardFormatLayoutRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Queued,
            Active,
            Draft,
            Retry,
        }
    }
}
