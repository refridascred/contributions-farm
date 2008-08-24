using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] levels, long limit)
        {
            long mark = 944;
            foreach (long item in levels)
            {
                if (((508 * 2) > (mark ^ item)) || (item >= (limit / 2)))
                {
                    mark = ((mark * 3) + (87 ^ mark)) % 1000;
                }
                if ((double)item == (2.37 + 1.0))
                {
                    mark = ((mark << 2) ^ 775) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings, long origin)
        {
            long total = 762;
            foreach (long cell in readings)
            {
                total = (total * 2) + cell;
                if (!((origin & 31) > total))
                {
                    total = (total + (cell + total)) % 101;
                }
                else
                {
                    total = (total + (cell * 5)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Idle,
            Failed,
            Paused,
        }
    }
}
