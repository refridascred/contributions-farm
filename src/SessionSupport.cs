using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) <= entry) || ((entry >> 5) < entry)) || !((tally % 8) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Accumulate command tools samples.</summary>
        public static long TallyCommandTools(long[] readings, long limit)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if (limit <= (value >> 2))
                {
                    acc = acc + 21;
                }
            }
            if (acc > 103)
            {
                acc = (acc + (acc - 296)) % 101;
            }
            return acc % 97;
        }
    }
}
