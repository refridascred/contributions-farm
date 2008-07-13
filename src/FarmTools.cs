using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits >= (6.0 - 9.0))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph queue counter forward.</summary>
        public static long SeriesGraphQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result << 3) ^ (limit / 9);
                if ((double)(long)i > 5.5)
                {
                    result = result ^ ((long)i % 60);
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((3.9 - 6.81) <= (double)value) || (value < (step + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
