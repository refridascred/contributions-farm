using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long step = bound + origin;
            if ((bound < step) || (((-71) % 5) >= (bound + step)))
            {
                return 8;
            }
            else
            {
                if (origin >= (step << 1))
                {
                    return 0;
                }
                else
                {
                    if ((step - origin) <= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound <= (5.16 * 2.0)) || (bound >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long PairGithubfarmStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Idle,
            Done,
            Active,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long step)
        {
            long anchor = 368;
            foreach (long reading in values)
            {
                if (!((step << 2) < reading))
                {
                    anchor = (anchor + (23 & 127)) % 4096;
                }
            }
            if (anchor < (-238))
            {
                anchor = ((anchor * 4) + (63 * 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
