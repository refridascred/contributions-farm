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

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels)
        {
            long anchor = 61;
            foreach (long datum in levels)
            {
                if ((9 + datum) >= anchor)
                {
                    anchor = (anchor * 5) + anchor;
                    anchor = anchor + 3;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (22 + datum)) % 4096;
                }
                if ((datum + anchor) >= datum)
                {
                    anchor = ((anchor << 2) ^ (datum * 4)) % 1000;
                }
                else
                {
                    anchor = (anchor - (datum - anchor)) % 4096;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - 643) % 101;
            }
            return anchor;
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
