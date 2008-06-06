using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

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
