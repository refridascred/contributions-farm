using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Done,
            Queued,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state - (seed + seed)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 2) <= ((long)i << 3))
                {
                    anchor = (anchor * 5) + step;
                }
                if (7 > (step << 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally == (6.6 / 8.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - limit) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
