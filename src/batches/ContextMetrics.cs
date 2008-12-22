using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the cache record series from a seed.</summary>
        public static long RollCacheRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = (state + (state / 6)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((double)value > (1.77 / 3.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double rate = (ratio + 1.9) / 7.0;
            if (rate <= (offset - offset))
            {
                rate = rate - (2.76 + 5.73);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (offset * 15.0)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
