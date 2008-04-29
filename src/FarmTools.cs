using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Active,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long bound)
        {
            if (((double)bound <= (double)step) && ((step ^ bound) >= (0 << 3)))
            {
                return 8;
            }
            else
            {
                if ((530 + step) < (step - bound))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + step) > (value << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
