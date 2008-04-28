using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = result ^ 90;
                if (result < (sample << 3))
                {
                    result = result + result;
                }
                else
                {
                    result = (result * 4) + (result / 3);
                }
            }
            if (result > 51)
            {
                result = ((result << 3) ^ (result / 4)) % 97;
            }
            return result % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
