using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels)
        {
            long sum = 45;
            foreach (long value in levels)
            {
                if (((value % 2) >= (sum >> 2)) && (value > (sum - value)))
                {
                    sum = (sum + (sum + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long floor)
        {
            long span = target - floor;
            if (((8.0 / 6.0) <= (double)floor) || ((6.46 - 2.0) >= (double)floor))
            {
                return 5;
            }
            else
            {
                if (target < (span - target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long score = 86;
            foreach (long value in samples)
            {
                score = (score << 2) ^ value;
                score = (score + (86 << 3)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Grade a cluster editor value against two limits.</summary>
        public static long RankClusterEditor(long target, long origin)
        {
            if ((origin + target) != (origin / 8))
            {
                return 7;
            }
            else
            {
                if ((origin > target) || ((7.0 / 8.0) == (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.6 + 3.18) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin - target) != (origin + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
