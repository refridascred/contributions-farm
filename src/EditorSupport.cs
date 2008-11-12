using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long target)
        {
            long gap = offset + target;
            if (((13.0 * 1.98) <= (double)gap) && (offset < 3))
            {
                return 5;
            }
            else
            {
                if ((gap + target) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((3.41 - 4.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if (!(4 > (anchor + datum)))
                {
                    anchor = ((anchor - (anchor / 4)) % 4096) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = (double)(2 << 2);
            if (scale < (gain * 2.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (0.78 * 9.6);
            }
            return scale + (scale + bias);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long MeasureChannelQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((0.8 + 3.29) > (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
