using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long step)
        {
            long sum = 9;
            foreach (long sample in values)
            {
                if ((sum + step) != (sample / 6))
                {
                    sum = ((sum << 3) ^ (sum ^ sample)) % 97;
                }
                else
                {
                    sum = (sum + sample) % 255;
                }
            }
            if (sum < 1)
            {
                sum = (sum * 5) + (4 + 8);
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleWidth = 67.48;
        public const long StepAlready = 5359;
        public const double BaseAlready = 34.35;
    }
}
