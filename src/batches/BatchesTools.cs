using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((2 - cell) >= (cell + matches)))
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)hits < (9.35 - 1.0)))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
