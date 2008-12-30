using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 3) < (entry << 3))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long diff = offset ^ target;
            if ((double)target > (1.7 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((offset / 3) >= (diff + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) > (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset < (3.65 * 1.44))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
