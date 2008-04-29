using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = state ^ (reading ^ state);
                state = ((state * 4) + state) % 65521;
                state = (state - (reading ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 315;
        public const long LimitFilter = 8611;
        public const double DefaultFilter = 60.12;
        public const long IdleDepth = 231;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
