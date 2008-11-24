using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 237;
            foreach (long entry in items)
            {
                if (sum >= (entry * 3))
                {
                    sum = (sum << 2) ^ (entry & 31);
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long floor)
        {
            long delta = target ^ floor;
            if ((target + target) == (target - 5))
            {
                return 6;
            }
            else
            {
                if (delta < (target % 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
