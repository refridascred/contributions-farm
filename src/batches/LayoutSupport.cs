using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state + (57 + (long)i)) % 101;
                if ((state * 3) > (offset - state))
                {
                    state = (state ^ offset) % 4096;
                }
                else
                {
                    long span = (650 / 7) ^ (state + offset);
                    state = state ^ (76 + span);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the editor already series from a seed.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (target < (84 ^ (long)i))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 162;
        public const long StepRecord = 204;
        public const string LimitRecord = "open";
        public const long WindowRecord = 7750;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
