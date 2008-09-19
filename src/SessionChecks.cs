using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > (offset + offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + 15) != (sample + 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch context entries.</summary>
        public static long TallyBatchContext(long[] items, long seed)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (acc & 127)) % 255) - seed;
                if (!((reading % 97) >= (reading / 9)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
