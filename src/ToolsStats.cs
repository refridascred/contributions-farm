using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a entry account counter forward.</summary>
        public static long StepEntryAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (state & 31)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Stale,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 5595;
        public const long StepProfile = 8754;
        public const long WindowTimeout = 7243;

        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double bias, double offset)
        {
            double load = offset * 8.99;
            if (load < bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (3.36 - bias)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
