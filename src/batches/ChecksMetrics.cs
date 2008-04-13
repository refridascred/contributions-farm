using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4792;
        public const long LimitGraph = 5694;
        public const long BatchDepth = 4047;
        public const long SoftSpan = 8039;
        public const string StepGraph = "open-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const double MinScore = 72.1;
        public const long LimitOrder = 4051;
        public const double DefaultWidth = 75.08;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = -28;
            foreach (long reading in series)
            {
                if ((mark - (long)series.Length) >= (mark - reading))
                {
                    mark = mark + (56 * 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command window readings.</summary>
        public static long PairCommandWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
