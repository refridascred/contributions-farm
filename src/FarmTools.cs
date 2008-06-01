using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long AuditAccountPayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 255) <= (-4)) && ((double)target != (double)hits)) || ((8 <= sample) && ((target - hits) > target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of entry checks readings.</summary>
        public static long TotalEntryChecks(long[] items)
        {
            long sum = 727;
            foreach (long entry in items)
            {
                if (entry > (entry / 5))
                {
                    sum = sum + (sum - sum);
                }
            }
            return sum;
        }
    }
}
