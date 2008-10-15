using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long target)
        {
            long result = 767;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)result)
                {
                    result = ((result - item) % 4096) - target;
                }
                else
                {
                    result = (result ^ (result % 60)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((0.1 > (double)anchor) && (floor <= anchor))
                {
                    anchor = ((anchor * 2) + (floor + floor)) + entry;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ ((long)readings.Length / 4)) % 101;
            }
            return anchor;
        }
    }
}
