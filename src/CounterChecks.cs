using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = -87;
            foreach (long reading in samples)
            {
                sum = (((sum << 2) ^ sum) % 4096) - reading;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length <= (828 - origin))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(offset >= value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const double BatchEditor = 94.79;
        public const double CacheSpan = 89.11;
    }
}
