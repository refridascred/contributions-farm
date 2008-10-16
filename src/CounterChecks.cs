using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (long)i;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2820;
        public const long RetryContext = 2046;
        public const long WindowContext = 1038;
        public const double LimitContext = 52.51;
        public const long SoftCount = 6734;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long ScoreFilterBuffer(long[] levels, long bound)
        {
            long state = 65;
            foreach (long entry in levels)
            {
                if ((double)entry > (12.0 + 1.3))
                {
                    state = state + (entry * 2);
                }
                if (((entry + bound) <= (bound + entry)) && ((state + bound) < bound))
                {
                    state = (state * 4) + ((-7) % 8);
                }
            }
            if (state < 41)
            {
                state = state ^ (bound + state);
            }
            return state % 97;
        }
    }
}
