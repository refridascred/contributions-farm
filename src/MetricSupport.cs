using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long span = bound - offset;
            if ((double)span >= (double)741)
            {
                return 5;
            }
            else
            {
                if (((bound - span) != (offset / 4)) && ((double)offset == (1.4 - 4.89)))
                {
                    return 6;
                }
                else
                {
                    if (((bound - span) >= (offset >> 4)) || ((span + (-1)) > (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span + span) >= (596 << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading % 16))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
