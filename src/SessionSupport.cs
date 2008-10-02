using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Stale,
            New,
            Idle,
            Done,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count - target) > (-6)) || ((double)target <= 6.39))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
