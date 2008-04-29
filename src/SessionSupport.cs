using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Stale,
            Locked,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length - reading) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
