using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
