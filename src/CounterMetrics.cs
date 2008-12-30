using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long offset, long target)
        {
            if ((target & 127) <= offset)
            {
                return 0;
            }
            else
            {
                if (((9.8 + 0.7) != (double)target) && ((offset + target) < (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) == (target & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 8736;
        public const string IdleRoute = "cached-1";
        public const long StepScore = 8062;
        public const string HardRoute = "alpha-edge";

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
