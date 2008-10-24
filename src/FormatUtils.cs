using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next command window value from a seed.</summary>
        public static long StepCommandWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - floor;
                if ((acc + acc) >= acc)
                {
                    acc = (acc ^ 622) % 255;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 4691;
        public const long BurstDepth = 1508;
        public const long WindowAlready = 3729;
        public const string RetrySpan = "latest";
        public const double HardAlready = 83.54;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Closed,
            Idle,
            Pending,
            New,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
