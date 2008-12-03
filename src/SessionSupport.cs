using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell >= count)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
