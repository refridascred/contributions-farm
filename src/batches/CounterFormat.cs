using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double scale = (double)(62 / 8);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - 4.5) + (double)(long)i) - bias) + floor;
            }
            return scale - 6.5;
        }

        /// <summary>Count farm checks pairs that satisfy a relation.</summary>
        public static long CompareFarmChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
