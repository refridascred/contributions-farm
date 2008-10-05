using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (14.0 + 17.0))
                {
                    hits = ((hits + 2) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long CountNotesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) != (item ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values)
        {
            long score = 78;
            foreach (long cell in values)
            {
                score = ((score ^ (score << 2)) % 65521) - cell;
                score = (score + (score * 4)) % 255;
            }
            if (score < 2)
            {
                score = ((score << 2) ^ (0 & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
