using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)result < (9.38 * 8.1))
                {
                    result = (result * 5) + (target - target);
                }
                result = (result * 2) + (long)i;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseScore = 9506;
        public const long IdleLevel = 3744;
        public const string StepEditor = "latest";
        public const long RetryEditor = 5655;
        public const long DefaultEditor = 1403;
    }
}
