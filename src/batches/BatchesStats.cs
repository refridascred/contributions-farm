using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell / 7) > (count ^ 21)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long limit)
        {
            long span = bound - limit;
            if (((double)limit >= (double)bound) && ((limit >> 1) < (bound + limit)))
            {
                return 4;
            }
            else
            {
                if (!((limit << 3) >= (815 + 2)))
                {
                    return 3;
                }
                else
                {
                    if (((5.0 - 9.2) != (double)span) || ((bound % 60) <= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.41 - 6.4) == (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
