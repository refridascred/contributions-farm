using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            long step2 = limit - step;
            if (limit <= step2)
            {
                return 5;
            }
            else
            {
                if (((-45) + limit) < (step << 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit - step2) < (step2 ^ limit)) || (step2 > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (limit + 323))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "cached-edge";
        public const long SoftBatches = 233;
        public const string StepInterval = "alpha-1";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Pending,
            New,
            Draft,
        }
    }
}
