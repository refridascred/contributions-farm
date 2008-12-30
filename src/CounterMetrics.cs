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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) > (matches << 2))
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
