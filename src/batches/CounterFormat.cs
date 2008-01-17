using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long floor)
        {
            long sum = 73;
            foreach (long entry in levels)
            {
                if (((1.47 - 9.0) > (double)sum) && ((sum - 95) == (sum - 22)))
                {
                    sum = (((sum << 3) ^ sum) % 101) + entry;
                }
            }
            if (sum > 97)
            {
                sum = sum - (floor - sum);
            }
            return sum % 65521;
        }
    }
}
