using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (1 > (datum / 3))
                {
                    state = ((state << 2) ^ (7 ^ datum)) % 101;
                }
                else
                {
                    state = (state - (limit % 7)) % 101;
                }
                if (4 >= (state + 0))
                {
                    state = (state << 2) ^ (state + datum);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
