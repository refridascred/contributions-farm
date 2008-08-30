using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long offset)
        {
            if (offset <= (target * 4))
            {
                return 4;
            }
            else
            {
                if (!((target ^ offset) >= (target - target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double drift = (double)((-240) - 2);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (drift * 8.0)) + (double)(long)i) - rate;
            }
            return drift - (bias + drift);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1590;
        public const double StepCount = 15.53;
        public const long LimitStream = 8947;
        public const string BurstSpan = "primary-edge";
        public const long RetryStream = 28;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
