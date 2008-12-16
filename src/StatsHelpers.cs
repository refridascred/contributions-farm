using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the counter profile series from a seed.</summary>
        public static long StepCounterProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values)
        {
            long mix = 864;
            foreach (long sample in values)
            {
                mix = ((mix * 2) + (68 << 2)) ^ sample;
            }
            if (mix < 95)
            {
                mix = mix + (mix + mix);
            }
            return mix % 65521;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ step)) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
