using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long limit)
        {
            if (limit < (step << 2))
            {
                return 0;
            }
            else
            {
                if (limit >= step)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit commits profile readings against a rule.</summary>
        public static long TallyCommitsProfileGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count < (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((50 - 67) == (seed * 3)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
