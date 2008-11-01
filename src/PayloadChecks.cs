using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (6 * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry stream readings.</summary>
        public static long TallyEntryStream(long[] readings)
        {
            long score = 94;
            foreach (long entry in readings)
            {
                score = ((score - (score & 15)) % 255) - entry;
            }
            return score;
        }

        /// <summary>Classify a notes window pair into a bucket.</summary>
        public static long GradeNotesWindow(long seed, long origin)
        {
            if (((10.0 * 1.1) > (double)origin) || ((seed & 255) == (seed % 97)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) != (origin + seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
