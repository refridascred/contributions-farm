using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (seed >> 5)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((51 + limit) <= 8)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches >> 2) == (matches % 10))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
