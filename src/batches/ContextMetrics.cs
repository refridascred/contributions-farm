using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result ^ (91 - floor)) - (long)i2;
                    result = (result + (floor + result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long MeasureGraphQueueGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((floor & 15) >= (value / 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = (anchor * 2) + anchor;
                anchor = anchor + (anchor % 5);
                anchor = anchor - reading;
            }
            return anchor % 4096;
        }
    }
}
