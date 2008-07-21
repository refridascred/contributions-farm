using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count * 3) < (entry >> 3)) || !((double)entry > (1.0 * 8.0)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)matches)
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long origin)
        {
            if (4 <= target)
            {
                return 1;
            }
            else
            {
                if (((double)origin <= (5.0 / 7.0)) && (target >= (target + target)))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) > (target & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - target) > (origin % 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
