using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 192;
        public const string MaxWidth = "staging";
        public const long MaxInterval = 9430;
        public const long MinFactor = 5471;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((step > (411 - step)) && ((step ^ (long)readings.Length) != ((-663) >> 4))) || !((step + step) <= (324 / 5)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Done,
            Active,
            Queued,
            Idle,
        }
    }
}
