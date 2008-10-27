using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up stream batch samples.</summary>
        public static long MatchStreamBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Retry,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long offset)
        {
            if ((7 >> 4) != (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((step ^ offset) >= step)
                {
                    return 8;
                }
                else
                {
                    if (!((step >> 2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 5) != (step * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
