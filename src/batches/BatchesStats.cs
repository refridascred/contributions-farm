using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9394;
        public const long BaseDepth = 416;
        public const long RetryGithubfarm = 3875;
        public const double MinSize = 29.63;
        public const long MaxGithubfarm = 8412;

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            if ((origin2 > (9 - origin2)) && ((origin / 7) > (origin & 7)))
            {
                return 5;
            }
            else
            {
                if (((-41) + origin) == (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) <= (3 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
