using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double load = (double)(375 << 1);
            if (load <= (gain - load))
            {
                load = load + (double)93;
            }
            else
            {
                load = load - 5.3;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor - 5.0)) + (double)(long)i;
            }
            return load - (load / 4.0);
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long mark = -900;
            foreach (long reading in values)
            {
                mark = (mark + (reading + reading)) - bound;
                mark = (mark + (mark + reading)) % 101;
            }
            return mark % 65521;
        }
    }
}
