using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a notes contributi pair into a bucket.</summary>
        public static long GradeNotesContributi(long limit, long floor)
        {
            if (((196 + 4) <= (limit * 3)) || ((double)limit > 1.97))
            {
                return 8;
            }
            else
            {
                if ((1.56 + 14.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (0 >= (floor + 66))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            if (limit >= limit2)
            {
                return 4;
            }
            else
            {
                if ((limit2 + limit2) == (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((27 >> 2) <= (957 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
