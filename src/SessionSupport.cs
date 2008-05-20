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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
