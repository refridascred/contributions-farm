using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((9.72 * 13.0) >= (double)sample) && ((sample + sample) >= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
