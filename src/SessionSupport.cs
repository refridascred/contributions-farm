using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 6055;
        public const long StepOrder = 9954;
        public const long IdleOrder = 3957;
        public const string SoftSpan = "legacy-v2";

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = -90;
            foreach (long item in data)
            {
                acc = acc - (item * 5);
                if ((item % 60) != ((-2) / 6))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (origin << 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
