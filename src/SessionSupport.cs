using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((step <= (step << 2)) || (count <= (17 - count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long cell in readings)
            {
                anchor = ((((anchor * 3) + (anchor >> 2)) % 255) - cell) - step;
            }
            return anchor % 1000;
        }
    }
}
