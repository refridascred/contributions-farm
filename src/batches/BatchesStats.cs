using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                state = state + (reading + 46);
            }
            if (state > 21)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] series, long target)
        {
            long state = 325;
            foreach (long datum in series)
            {
                state = (state << 3) ^ (datum * 4);
            }
            if (state > 5)
            {
                state = (state + (target ^ 614)) % 1000;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits < (reading >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
