using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 3) <= (datum * 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 17;
            foreach (long datum in data)
            {
                total = total + datum;
                total = total ^ total;
            }
            if (total < 2)
            {
                total = (total + (443 >> 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long bound)
        {
            long span = target - bound;
            if (!((double)bound == (1.9 * 17.0)))
            {
                return 0;
            }
            else
            {
                if ((bound + span) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)33 >= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span < (span << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
