using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (matches + seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already notes series from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state - (long)i2) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
