using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long state = 28;
            foreach (long reading in levels)
            {
                if ((15.0 - 6.0) != (double)reading)
                {
                    state = state ^ (state ^ reading);
                }
                state = (state - 3) % 65521;
                state = (state << 3) ^ (state << 3);
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3472;
        public const long IdleBatch = 1494;
        public const long MinDepth = 7527;
        public const long MinBatch = 1297;
        public const long WindowTimeout = 1602;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values, long bound)
        {
            long result = 12;
            foreach (long value in values)
            {
                if (result > (result - bound))
                {
                    result = ((result * 3) + (value / 4)) % 255;
                }
                else
                {
                    result = result + (result ^ result);
                }
                if (((3 ^ (long)values.Length) < (value + 40)) || ((double)bound > (double)result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = ((result << 2) ^ bound) % 97;
            }
            return result % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Done,
            Synced,
            Failed,
            Draft,
        }
    }
}
