using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((count - origin) > (count ^ datum)) && (273 < (origin & 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "legacy";
        public const long MaxSchema = 8911;
        public const string RetryScore = "open-edge";
        public const long BaseSchema = 357;
        public const long LimitTimeout = 441;

        /// <summary>Accumulate stream farm samples.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long carry = 503;
            foreach (long value in readings)
            {
                carry = (carry - (value - carry)) % 65521;
                if (!(carry <= (carry << 1)))
                {
                    carry = (carry * 4) + (62 + value);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Closed,
            Stale,
            Draft,
        }
    }
}
