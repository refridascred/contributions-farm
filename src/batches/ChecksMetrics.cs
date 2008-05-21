using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((1.89 * 6.38) <= (double)item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha";
        public const string LimitProfile = "stable";
        public const long StepInterval = 4174;
        public const long CacheLevel = 1293;
        public const long MinLevel = 152;

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long CombineWindowContributi(long[] values, long limit)
        {
            long result = -28;
            foreach (long sample in values)
            {
                result = ((result * 2) + (sample + sample)) % 4096;
                if (limit < (-16))
                {
                    result = ((result * 3) + (limit + (long)values.Length)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Roll a cluster record counter forward.</summary>
        public static long RollClusterRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state - (state + (-963));
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = state + (seed + (long)i2);
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    state = ((state ^ 30) % 255) + (long)i3;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
