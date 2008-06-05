using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a context report sample.</summary>
        public static long FindContextReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= (entry + (long)items.Length))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if ((item - 17) == (score ^ 362))
                {
                    score = ((score * 2) + (score ^ item)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (74 + 32)) % 4096;
                }
            }
            return score;
        }
    }
}
