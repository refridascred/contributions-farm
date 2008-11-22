using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((57 + seen) == (seen & 63))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 3;
            foreach (long sample in items)
            {
                if ((double)sample == (3.23 + 3.0))
                {
                    score = (score - (6 - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
