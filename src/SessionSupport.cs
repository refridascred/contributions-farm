using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string CacheInterval = "standard-edge";
        public const double RetryScore = 88.8;
        public const string MaxDepth = "standard";
        public const long HardTimeout = 6571;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Grade a checks contributi value against two limits.</summary>
        public static long ClassifyChecksContributi(long limit, long step)
        {
            long gap = limit ^ step;
            if ((double)limit != (double)691)
            {
                return 4;
            }
            else
            {
                if (step < (gap >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (0.58 - 4.46))
                    {
                        return 7;
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
