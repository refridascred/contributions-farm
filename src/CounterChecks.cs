using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Done,
            Draft,
            Active,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Pending,
            Retry,
            New,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item >> 2) <= 123)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum - (target >> 4);
                sum = (sum * 2) + (0 / 9);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
