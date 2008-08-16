using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long target)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                sum = (((sum * 4) + datum) % 97) + target;
            }
            return sum % 65521;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 3398;
        public const string MaxBudget = "strict-edge";
        public const long MinCounter = 9945;
        public const long StepTimeout = 4848;
    }
}
