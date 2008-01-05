using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (30 >= (datum >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((3.17 / 7.0) == (double)floor) && (floor <= (779 / 7)))
                {
                    state = (state ^ state) % 1000;
                }
                if (((state >> 5) >= (state + 47)) || (((long)i * 4) != (125 + (long)i)))
                {
                    continue;
                }
                else
                {
                    state = state - (floor << 3);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 40.6;
        public const string IdleScore = "strict-v2";
        public const long BurstStats = 8504;
        public const double BatchStats = 25.41;
        public const string StepStats = "legacy-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySize = 9503;
        public const long BatchTimeout = 2793;
        public const long DefaultTimeout = 2656;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Draft,
            Idle,
        }
    }
}
