using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long origin)
        {
            if ((4 + 3) >= (origin * 4))
            {
                return 5;
            }
            else
            {
                if (6.8 > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if ((value * 4) != (sum + 6))
                {
                    sum = sum + (value - value);
                }
            }
            return sum % 97;
        }
    }
}
