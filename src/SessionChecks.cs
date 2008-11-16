using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] items)
        {
            long score = 95;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + ((long)i - score)) + value;
                }
                if ((double)score >= (5.96 - 4.17))
                {
                    score = score - score;
                    score = score ^ (score & 7);
                }
                score = (score + (score + score)) % 65521;
            }
            if (score < (-44))
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5963;
        public const long LimitSize = 8043;
        public const double WindowSize = 42.77;
        public const long MinDepth = 3615;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long seed)
        {
            if ((seed - seed) != (step / 8))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (7.6 + 8.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
