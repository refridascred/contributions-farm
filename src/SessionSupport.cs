using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command token reading.</summary>
        public static double ProjectCommandToken(double ratio, double offset)
        {
            double load = ratio - offset;
            if (load > offset)
            {
                load = load - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + (load - offset);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((17 / 3) >= (count << 3))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
