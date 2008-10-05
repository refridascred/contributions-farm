using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long offset)
        {
            if ((limit << 2) > (limit << 3))
            {
                return 0;
            }
            else
            {
                if ((7.0 / 4.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (limit < (13 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.1 * 8.0) < 0.99)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + mark;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed >> 1) != (matches % 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Locked,
            Retry,
            Paused,
            Dropped,
        }
    }
}
