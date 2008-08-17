using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (3.9 + 9.55))
                {
                    matches = ((matches + 3) ^ reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the checks contributi entries that pass the check.</summary>
        public static long AuditChecksContributiMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((double)tally == (9.1 / 9.0)))
                {
                    tally = ((tally + 1) + sample) + target;
                }
            }
            return tally;
        }
    }
}
