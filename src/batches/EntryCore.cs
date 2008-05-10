using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "staging-edge";
        public const long MaxDepth = 2439;
        public const long IdleChannel = 6280;
        public const long SoftChannel = 437;
        public const long BaseChannel = 7266;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (origin > (origin & 15))
            {
                return 6;
            }
            else
            {
                if (!((origin % 12) <= (offset + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((cur + origin) == (61 + origin)) || (3 > offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length & 3) < ((long)readings.Length + origin))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) == (sample >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
