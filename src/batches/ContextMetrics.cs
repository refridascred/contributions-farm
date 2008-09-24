using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((5 <= (count & 1)) || !((double)count >= (1.2 * 3.5)))
                {
                    count = ((count + 1) - item) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long target)
        {
            long edge = bound ^ target;
            if ((4.95 / 9.0) < (3.9 * 9.08))
            {
                return 3;
            }
            else
            {
                if ((840 + target) > 9)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)edge == (1.0 + 2.0)) || ((bound + 17) >= (edge << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            long offset = step + seed;
            if (((seed >> 4) <= offset) && ((step * 3) <= (step + seed)))
            {
                return 4;
            }
            else
            {
                if (((seed / 3) > (offset / 5)) && ((offset - 2) < 4))
                {
                    return 8;
                }
                else
                {
                    if (((0.37 + 15.0) <= (double)offset) && ((seed + offset) >= (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 2) < 468)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (tally + 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 63.62;
        public const long MinNotes = 245;
        public const long MaxNotes = 4497;
    }
}
