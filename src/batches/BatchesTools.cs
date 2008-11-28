using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4.0 / 5.0) >= (double)entry) && ((double)entry < (6.29 - 7.02)))
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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
