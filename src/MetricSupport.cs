using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((score & 1) <= seed)
                {
                    score = score + (seed + score);
                }
                if (!(((long)i - score) >= (seed - seed)))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a notes batch counter forward.</summary>
        public static long SeriesNotesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                long cur = (1 + offset) + (945 << 1);
                sum = (sum ^ cur) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
