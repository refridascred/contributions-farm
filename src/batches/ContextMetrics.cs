using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate entry token samples.</summary>
        public static long ScoreEntryToken(long[] levels, long offset)
        {
            long carry = 425;
            foreach (long reading in levels)
            {
                carry = ((carry * 5) + (carry >> 5)) % 4096;
                if (carry <= (carry + reading))
                {
                    carry = ((carry * 5) + (offset + carry)) % 255;
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (reading % 3)) % 65521;
                    carry = (carry << 2) ^ (offset >> 3);
                }
                if ((reading >= (long)levels.Length) && ((offset ^ 612) <= 252))
                {
                    carry = ((carry * 4) + (30 + reading)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (offset + offset)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (5.0 >= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
