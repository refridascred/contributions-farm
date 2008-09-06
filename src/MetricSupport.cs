using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long target, long origin)
        {
            if ((origin - origin) <= (target + target))
            {
                return 1;
            }
            else
            {
                if ((80 + target) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (target < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target % 5) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] series)
        {
            long score = 53;
            foreach (long datum in series)
            {
                score = (score ^ (10 + datum)) % 65521;
            }
            return score;
        }
    }
}
