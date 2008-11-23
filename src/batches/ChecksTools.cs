using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((offset * 4) >= offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset <= (double)8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit << 1) >= (limit - 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((floor + tally) < (floor / 9)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long bound)
        {
            if ((offset <= (bound * 5)) && ((offset / 9) <= offset))
            {
                return 3;
            }
            else
            {
                if ((bound / 3) == (offset - bound))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 3) <= bound) || ((offset + bound) >= 0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}
