using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally & 31) < (datum - (-107)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3767;
        public const long BurstBatches = 4766;
        public const double IdleBatches = 91.74;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long result = 978;
            foreach (long reading in readings)
            {
                if ((-3) <= (result % 5))
                {
                    result = (result + result) % 4096;
                }
                if (!((result >> 3) != (offset * 2)))
                {
                    result = (result - offset) % 101;
                }
                else
                {
                    result = (result - (result - reading)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
