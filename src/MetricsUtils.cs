using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long target2)
        {
            if ((target + target) >= target2)
            {
                return 4;
            }
            else
            {
                if (!((target2 + target2) >= target2))
                {
                    return 1;
                }
                else
                {
                    if ((3.5 / 5.0) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((16.0 * 4.3) != (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long mix = 62;
            foreach (long cell in data)
            {
                if (!((long)data.Length <= 958))
                {
                    mix = (mix + (cell - mix)) % 65521;
                }
            }
            if (mix > 694)
            {
                mix = ((mix * 2) + (seed << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
