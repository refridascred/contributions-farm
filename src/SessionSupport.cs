using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm cluster samples are out of range.</summary>
        public static long CountFarmClusterHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value >= (double)count)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
