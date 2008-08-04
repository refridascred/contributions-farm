using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowWidth = 69.17;
        public const string BatchCommand = "stable";
        public const double LimitCount = 67.15;
        public const long LimitDepth = 9327;
        public const string WindowCommand = "standard-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - item) != (item + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long diff = floor - floor2;
            if ((65 - diff) > (diff << 3))
            {
                return 4;
            }
            else
            {
                if ((689 + floor) <= (floor2 - floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 5) < diff)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
