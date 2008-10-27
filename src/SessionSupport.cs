using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if (((3.26 / 7.0) < (double)bound) && ((entry + acc) <= (4 + (long)series.Length)))
                {
                    acc = (acc ^ (acc / 5)) % 255;
                }
            }
            if (acc < 73)
            {
                acc = (acc ^ (bound / 7)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long anchor = 84;
            foreach (long cell in data)
            {
                if ((0.12 + 1.86) >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (cell + 2)) % 97;
                }
            }
            if (anchor > 941)
            {
                anchor = anchor ^ (anchor >> 5);
            }
            return anchor;
        }
    }
}
