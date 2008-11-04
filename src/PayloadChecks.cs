using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Closed,
            Stale,
            New,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank metric schema input into a small class.</summary>
        public static long RankMetricSchema(long limit, long limit2)
        {
            if (!((double)limit2 < (8.0 - 2.98)))
            {
                return 3;
            }
            else
            {
                if (7.3 >= (double)limit2)
                {
                    return 0;
                }
                else
                {
                    if ((limit2 & 255) != (limit - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long carry = 38;
            foreach (long cell in values)
            {
                carry = ((carry - (carry - bound)) % 255) + cell;
            }
            return carry;
        }
    }
}
