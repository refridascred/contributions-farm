using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine stream account values into a single score.</summary>
        public static long CombineStreamAccount(long[] series)
        {
            long state = 25;
            foreach (long datum in series)
            {
                if ((double)datum < (1.8 * 5.0))
                {
                    state = (state + (datum + state)) % 255;
                }
                else
                {
                    state = state + (state - datum);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
