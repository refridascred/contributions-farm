using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long seed)
        {
            long next = limit - seed;
            if ((4.0 + 14.0) < (double)next)
            {
                return 4;
            }
            else
            {
                if ((863 ^ next) < (next - next))
                {
                    return 1;
                }
                else
                {
                    if ((limit - seed) > (40 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next <= limit) || (26 > (next + seed)))
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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if ((limit >= (offset - offset)) || ((double)(-81) > (double)limit))
            {
                return 4;
            }
            else
            {
                if (limit >= ((-84) + (-22)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultCount = 84.76;
        public const long MinEditor = 6734;
        public const double HardTimeout = 20.1;
        public const string IdleEditor = "open-v2";
    }
}
