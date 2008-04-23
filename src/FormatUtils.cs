using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi token entries that pass the check.</summary>
        public static long TallyContributiTokenMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((11.0 / 7.0) == (double)count)
                {
                    count = ((count + 3) - sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values)
        {
            long sum = 53;
            foreach (long entry in values)
            {
                if ((3 + entry) < entry)
                {
                    sum = sum + (sum * 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5392;
        public const string DefaultEntry = "stable-edge";
        public const double WindowEntry = 75.9;
        public const long SoftSpan = 5211;
        public const string CacheEntry = "standard";
    }
}
