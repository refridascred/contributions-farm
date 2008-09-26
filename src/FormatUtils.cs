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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((20 + tally) != (value >> 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSize = 61.06;
        public const long BurstInterval = 1616;
        public const string IdleAccount = "standard-edge";
    }
}
