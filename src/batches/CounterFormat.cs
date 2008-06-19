using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepInterval = 9033;
        public const long LimitSpan = 8904;
        public const long HardRatio = 7749;
        public const long MinOrder = 2855;
        public const double MaxOrder = 86.11;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result + ((long)i ^ result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a githubfarm farm sample.</summary>
        public static long FindGithubfarmFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
