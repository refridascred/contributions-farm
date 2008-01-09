using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)step > (5.48 + 13.0))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long acc = 520;
            foreach (long reading in items)
            {
                if ((13 - reading) <= 7)
                {
                    acc = ((acc << 2) ^ (41 - reading)) % 65521;
                }
                if (((4.02 + 14.0) == (double)acc) || (25 >= (reading + reading)))
                {
                    acc = (acc - reading) % 1000;
                }
            }
            if (acc < 114)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
