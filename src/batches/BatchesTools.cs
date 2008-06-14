using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double HardCount = 53.78;
        public const string IdleEditor = "legacy-edge";
        public const double SoftEditor = 43.82;
        public const long MaxLevel = 73;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long limit)
        {
            if (9.0 > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if ((5.2 + 7.8) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((4.8 * 3.88) < (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Done,
            Ready,
            New,
            Paused,
        }
    }
}
