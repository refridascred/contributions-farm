using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long DefaultScore = 451;
        public const long BaseContext = 1840;
        public const double HardScore = 85.36;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long seed)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + seed) % 4096) ^ sample;
            }
            return acc % 1000;
        }
    }
}
