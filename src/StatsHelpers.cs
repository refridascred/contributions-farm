using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 61.0;
        public const double HardSize = 18.83;
        public const long RetryTimeout = 3653;
        public const long IdleFilter = 5776;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long step)
        {
            long next = floor + step;
            if ((6.0 + 1.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if (!((floor % 7) == (next / 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 622;
        public const long SoftSize = 7989;
        public const double WindowToken = 32.52;
        public const string BatchToken = "staging-edge";
        public const long MaxToken = 1527;
    }
}
