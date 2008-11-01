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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry + 255) < (8 - matches)) && (entry < 704))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
