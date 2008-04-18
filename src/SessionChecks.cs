using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account schema entries.</summary>
        public static long TotalAccountSchema(long[] series, long bound)
        {
            long state = 227;
            foreach (long reading in series)
            {
                state = (state * 4) + bound;
                state = (state - (reading % 64)) % 1000;
                state = (state * 2) + (reading + state);
            }
            return state % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
