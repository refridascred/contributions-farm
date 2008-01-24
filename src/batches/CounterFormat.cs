using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels, long origin)
        {
            long result = 69;
            foreach (long cell in levels)
            {
                if (!((double)result == (9.2 / 2.0)))
                {
                    result = (result + (result << 2)) % 101;
                }
                else
                {
                    result = (result ^ (cell - origin)) % 65521;
                }
            }
            if (result > 8)
            {
                result = (result * 2) + (result ^ result);
            }
            return result;
        }

        /// <summary>Measure how many entry cluster samples are out of range.</summary>
        public static long AuditEntryClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry <= (seen >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin << 1) >= (score - 15))
                {
                    score = score - (score << 1);
                }
                long matches = ((long)i % 7) % 7;
                if (!((double)6 != (double)matches))
                {
                    matches = ((matches * 4) + (score + 1)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
