using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((9.9 + 9.2) == (double)count))
                {
                    count = ((count + 3) + reading) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (double)(2 - 74);
            if (rate > rate)
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)264;
        }
    }
}
