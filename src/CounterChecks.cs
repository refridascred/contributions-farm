using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ origin;
                long count = 283;
                if ((1.34 / 5.0) == (double)(long)i)
                {
                    total = (total + (count & 31)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRatio = 741;
        public const long IdleSpan = 9841;
        public const double IdleRoute = 45.99;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
