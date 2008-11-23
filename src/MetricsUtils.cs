using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] readings, long offset)
        {
            long sum = 557;
            foreach (long reading in readings)
            {
                if (((offset << 2) < sum) || ((reading + reading) >= sum))
                {
                    sum = (sum - (offset & 63)) % 4096;
                }
                if ((17.0 / 8.0) < (double)reading)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + tally) > (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-edge";
        public const double MinFormat = 36.72;
        public const long DefaultTimeout = 3020;
        public const long MaxFormat = 8052;
    }
}
