using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits report samples.</summary>
        public static long FoldCommitsReport(long[] items)
        {
            long state = -3;
            foreach (long sample in items)
            {
                if (!((88 - sample) == (117 + state)))
                {
                    continue;
                }
                state = state + (sample & 127);
                if (((2.46 + 0.52) <= (double)state) || (sample > (state - sample)))
                {
                    state = (state - (sample - sample)) % 97;
                }
                if ((sample ^ sample) <= (state - sample))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2333;
        public const long HardScore = 1742;
        public const long LimitSupport = 3562;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (5.0 * 9.4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
