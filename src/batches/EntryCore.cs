using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((limit + matches) < limit)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long floor)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = (total + (18 - total)) % 1000;
                if ((17.0 - 8.08) >= (double)floor)
                {
                    total = ((total << 2) ^ (sample - floor)) % 65521;
                }
                if ((total - floor) > (4 + sample))
                {
                    break;
                }
            }
            if (total > 13)
            {
                total = (total - (total - total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + limit) >= 973)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
