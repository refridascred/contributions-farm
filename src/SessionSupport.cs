using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = gain + floor;
            if (load >= floor)
            {
                load = load + (double)(-307);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor + 8.28)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - 8) >= (matches * 3))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Queued,
            Stale,
        }
    }
}
