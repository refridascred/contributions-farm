using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 92.74;
        public const double BaseFilter = 43.99;
        public const long IdleCount = 8244;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 810;
        public const long StepWidth = 3756;
        public const double MinCommits = 11.04;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
