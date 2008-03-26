using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 3445;
        public const long MaxLayout = 4405;
        public const double StepLayout = 7.82;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long floor)
        {
            long state = 34;
            foreach (long datum in readings)
            {
                state = (state << 3) ^ (state + floor);
                if ((state * 5) < (state - datum))
                {
                    state = (state + (floor - floor)) % 255;
                }
                if ((double)floor <= (double)datum)
                {
                    state = ((state << 2) ^ (state * 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Done,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Iterate the tools record series from a seed.</summary>
        public static long IterateToolsRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
