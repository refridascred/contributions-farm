using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
