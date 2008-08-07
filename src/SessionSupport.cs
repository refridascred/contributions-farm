using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit filter report readings against a rule.</summary>
        public static long TallyFilterReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.88 > (double)item) && ((2 + item) > (tally - item)))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
