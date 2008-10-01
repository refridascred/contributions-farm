using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((5.5 * 5.2) == (double)datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter checks samples.</summary>
        public static long DigestFilterChecks(long[] readings)
        {
            long score = -8;
            foreach (long datum in readings)
            {
                score = ((score << 3) ^ datum) % 4096;
                if (!((2.7 / 5.0) <= (0.5 + 9.9)))
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 71)
            {
                score = (score + (score + 995)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
