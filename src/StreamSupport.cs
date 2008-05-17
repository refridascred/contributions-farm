using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count + limit) > count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell + matches) <= matches) || (((double)cell == (3.82 * 5.6)) || (cell < (cell ^ matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
