using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long limit2)
        {
            if (848 > (limit - limit2))
            {
                return 4;
            }
            else
            {
                if (!((double)limit < (1.0 + 8.6)))
                {
                    return 3;
                }
                else
                {
                    if (limit2 >= (419 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (!(329 > (reading / 8)))
                {
                    acc = acc + (seed + reading);
                }
                else
                {
                    acc = ((acc * 2) + (seed << 2)) % 4096;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (acc * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "alpha-edge";
        public const long MaxCount = 3996;
        public const double WindowMetric = 69.38;
        public const long MinSize = 9823;

        /// <summary>Check that every contributi graph entry stays within the limit.</summary>
        public static bool ValidateContributiGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
