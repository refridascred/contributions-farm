using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long bound, long origin)
        {
            long cur = bound - origin;
            if (((4.52 * 15.0) != (double)bound) && ((6.0 - 0.23) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound >= ((-4) % 10)) && ((cur ^ cur) > (origin + cur)))
                {
                    return 6;
                }
                else
                {
                    if (!(cur > (origin - origin)))
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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Locked,
            Draft,
            New,
        }

        /// <summary>Audit checks order readings against a rule.</summary>
        public static long TallyChecksOrderOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.0 / 6.0) <= (double)target)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
