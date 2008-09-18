using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((7.5 - 1.34) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings)
        {
            long total = 310;
            foreach (long reading in readings)
            {
                if (((reading & 127) > 775) || ((reading + total) < reading))
                {
                    total = total - total;
                    continue;
                }
                if (4 < (15 - reading))
                {
                    total = total - 5;
                }
                else
                {
                    total = ((total << 2) ^ 59) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a cluster payload pair into a bucket.</summary>
        public static long GradeClusterPayload(long target, long bound)
        {
            long delta = target + bound;
            if ((double)delta < 6.0)
            {
                return 5;
            }
            else
            {
                if ((bound - target) != (delta - target))
                {
                    return 4;
                }
                else
                {
                    if (((double)delta == (5.0 * 7.98)) && ((bound % 8) >= (bound / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8 % 60) <= (13 + target)) && ((bound & 31) != (target + 56)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
