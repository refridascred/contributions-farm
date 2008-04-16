using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token entry value from a seed.</summary>
        public static long DeriveTokenEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long AuditRecordCounterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - item) == (floor - 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long ClassifyFilterPayload(long floor, long limit)
        {
            if (((limit - floor) >= (floor / 9)) && ((3.48 + 9.0) == (double)limit))
            {
                return 2;
            }
            else
            {
                if ((floor - limit) > (9 % 16))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
