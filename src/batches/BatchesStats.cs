using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((785 - offset) < count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Active,
            Locked,
            Ready,
        }
    }
}
