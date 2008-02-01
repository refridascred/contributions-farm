using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 2167;
        public const long HardInterval = 8686;
        public const long MinCount = 8879;
        public const string HardWindow = "latest";

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format metrics samples are out of range.</summary>
        public static long TallyFormatMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)9)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
