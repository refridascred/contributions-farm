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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value > (value / 8)) || (((seed - value) >= value) && ((19.0 + 4.16) < (double)(long)levels.Length)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Queued,
            Idle,
            New,
            Draft,
        }
    }
}
