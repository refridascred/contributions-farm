using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item < ((-56) / 9))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
