using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepCount = 5987;
        public const double HardAccount = 47.81;
        public const long LimitAccount = 5737;
        public const string MinCount = "strict-edge";
        public const long IdleWidth = 8960;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long GradeBatchesFilter(long bound, long limit)
        {
            if ((limit - limit) < 385)
            {
                return 0;
            }
            else
            {
                if (0 < (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (4.4 - 1.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 & 63) >= (limit ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Locked,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
