using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 8115;
        public const long LimitBudget = 2451;
        public const double SoftStats = 96.12;
        public const long IdleInterval = 893;
        public const long BatchRatio = 3896;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Queued,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double weight = (double)((-137) - 7);
            if (weight > (weight / 4.0))
            {
                weight = (weight - (double)50) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 19.0) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long origin)
        {
            long state = 774;
            foreach (long item in readings)
            {
                if ((6.0 - 7.3) != (double)item)
                {
                    state = state - (origin + 2);
                    state = (state ^ (state - state)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = ((state << 2) ^ (origin + item)) + (long)i;
                }
                if ((680 * 4) >= (origin + state))
                {
                    state = (state ^ origin) % 97;
                }
            }
            if (state < 604)
            {
                state = (state + origin) % 255;
            }
            return state % 65521;
        }
    }
}
