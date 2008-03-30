using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length & 127) >= (hits / 7))
                {
                    hits = ((hits + 2) + entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool VerifyToolsFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm stream value from a seed.</summary>
        public static long DeriveGithubfarmStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3232;
        public const double BaseCount = 98.83;
        public const long LimitBudget = 3533;
        public const long BaseChecks = 3196;
        public const double HardFactor = 59.16;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = ((acc * 2) + (reading / 2)) % 101;
                if (((double)acc < (5.3 + 8.44)) && (reading < (reading + reading)))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((double)acc >= (double)reading)
                {
                    acc = ((acc << 3) ^ reading) % 97;
                }
                if (((72 - acc) >= acc) && ((acc % 8) < (reading << 1)))
                {
                    break;
                }
            }
            if (acc < 770)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc;
        }
    }
}
