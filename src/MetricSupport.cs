using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)reading >= (double)floor) && (6.9 <= (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            if ((target - target) >= (1 / 2))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= (616 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (((86 ^ target) == (998 ^ offset)) || (offset >= (offset % 16)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((913 - offset) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
