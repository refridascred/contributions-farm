using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((9.5 >= (double)sum) && ((sum + sum) <= sum))
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum * 3) + (value - 34);
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) != (282 ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long bound)
        {
            long state = 86;
            foreach (long value in data)
            {
                if (((state * 5) == (bound - 79)) || ((5 - state) <= state))
                {
                    state = (state << 3) ^ (value + state);
                }
            }
            return state % 97;
        }
    }
}
