using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6011;
        public const long SoftSize = 612;
        public const string HardReport = "alpha-edge";
        public const long BaseReport = 4017;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading / 9) < (61 & 3))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long TallyEntryBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen >> 1) < seen) || ((67 - sample) < (seen - seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
