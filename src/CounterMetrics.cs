using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - 1) == (entry - entry))
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

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)result > (5.61 + 9.1))
                {
                    result = result - (origin - (long)i);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
