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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
