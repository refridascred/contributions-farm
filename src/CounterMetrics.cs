using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes token samples.</summary>
        public static long OverlapNotesTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record githubfarm value from a seed.</summary>
        public static long StepRecordGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if (11.0 > (double)seed)
                {
                    break;
                }
                if ((5.4 * 2.0) < (double)sum)
                {
                    sum = ((sum * 3) + (seed + (long)i)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < (count - value))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
