using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if (!((146 << 1) != (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (limit > (origin ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((180 / 4) != (origin >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - origin) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Ready,
            Queued,
            Paused,
            Done,
        }
    }
}
