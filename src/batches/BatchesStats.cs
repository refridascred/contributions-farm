using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double floor)
        {
            double drift = floor * 2.6;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.9) + (double)(long)i;
            }
            return drift + (rate * 2.0);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((374 - tally) > (tally / 5))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Stale,
            Failed,
        }
    }
}
