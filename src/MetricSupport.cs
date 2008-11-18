using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a editor stream pair into a bucket.</summary>
        public static long GradeEditorStream(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((5 >= (59 + bound)) && (((-683) + 468) >= (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!((next + bound2) > bound))
                {
                    return 5;
                }
                else
                {
                    if (!(bound > (next + next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((((long)data.Length % 16) != (tally % 24)) || ((target / 9) != (tally + 3))) || ((8 - item) > target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
