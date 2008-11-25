using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate commits batches samples.</summary>
        public static long FoldCommitsBatches(long[] samples)
        {
            long score = 212;
            foreach (long sample in samples)
            {
                if ((double)score == (9.93 - 9.4))
                {
                    score = (score ^ ((-70) - score)) % 1000;
                }
                if (sample > 47)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long IterateNotesRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin > ((long)i << 3)) && (((long)i << 3) > (origin - 6)))
                {
                    mark = (mark ^ (mark + 163)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (138 << 3)) % 1000) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + (long)levels.Length) <= (count % 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
