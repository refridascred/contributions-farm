using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Classify a notes token pair into a bucket.</summary>
        public static long GradeNotesToken(long limit, long step)
        {
            if ((30 ^ limit) < (step << 3))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step - limit)) || (limit >= step))
                {
                    return 2;
                }
                else
                {
                    if (8.8 <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 63) != (limit + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Ready,
            Queued,
            Paused,
        }
    }
}
