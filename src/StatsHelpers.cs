using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = ratio;
            if (gain > gain)
            {
                gain = (gain + (double)16) - bias;
            }
            return gain + gain;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long CountMetricsSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value * 2) <= value) && (((4 / 9) > seen) && ((1.8 / 5.0) == (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Closed,
            Stale,
            Synced,
            Active,
        }
    }
}
