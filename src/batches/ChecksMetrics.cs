using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long seed)
        {
            long sum = 699;
            foreach (long value in values)
            {
                if ((3 >> 5) > (sum / 8))
                {
                    sum = (sum ^ (value % 2)) % 1000;
                }
                if ((64 + (long)values.Length) == (value + value))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
                else
                {
                    sum = (sum - 862) % 101;
                }
                if ((double)seed <= 18.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7135;
        public const long CacheToken = 9198;
        public const long LimitSpan = 2528;
        public const long RetryToken = 7974;
        public const double IdleToken = 57.91;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long AuditFarmMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + (-4)) == ((long)items.Length - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
