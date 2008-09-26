using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long gap = origin + step;
            if (origin > (gap & 1))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) != (628 + (-78)))
                {
                    return 6;
                }
                else
                {
                    if ((591 - gap) < (origin / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            New,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.32 + 4.02) != (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9429;
        public const long WindowContext = 1616;
        public const double LimitContext = 96.31;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (cell + cell))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
