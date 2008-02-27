using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((0.31 + 7.3) > (double)offset2)
            {
                return 6;
            }
            else
            {
                if ((step + offset) > (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 2) <= (offset2 + offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) > offset2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 7697;
        public const long BaseScore = 3048;
        public const long DefaultCommits = 603;
        public const long DefaultDepth = 4725;
        public const long HardCommits = 6713;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Idle,
            Active,
            Paused,
            Failed,
        }
    }
}
