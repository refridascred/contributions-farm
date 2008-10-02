using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc >= 9.56)
                {
                    acc = ((acc * 2) + (seed * 5)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "standard-edge";
        public const string MaxFormat = "staging-v2";
        public const double DefaultSize = 65.93;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long target)
        {
            long sum = 72;
            foreach (long entry in samples)
            {
                if (((sum % 2) > (entry * 5)) || (target <= (sum << 1)))
                {
                    sum = sum - (entry - entry);
                }
            }
            return sum;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long GradePayloadOrder(long step, long seed)
        {
            if (seed >= 764)
            {
                return 0;
            }
            else
            {
                if (!((step + step) >= (step * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + step) != (seed + 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
