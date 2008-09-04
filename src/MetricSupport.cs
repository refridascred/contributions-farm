using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long state = 86;
            foreach (long entry in levels)
            {
                if (!(entry < (8 + (long)levels.Length)))
                {
                    long diff = (entry + entry) % 64;
                    state = ((state * 5) + diff) % 65521;
                }
                if ((entry / 3) <= (entry << 3))
                {
                    state = (state + (entry / 8)) % 255;
                }
                if ((603 <= (state >> 1)) && ((19.0 / 9.0) > (double)entry))
                {
                    break;
                }
            }
            if (state < 757)
            {
                state = (state - (state * 2)) % 97;
            }
            return state % 97;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
