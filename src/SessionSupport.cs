using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) >= (42 - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double ratio = 9.7;
            if (ratio > 8.2)
            {
                ratio = (ratio + (double)2) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain * 8.11)) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
