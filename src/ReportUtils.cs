using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data, long seed)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((state - state) % 97) - reading;
            }
            if (state > 70)
            {
                state = ((state * 4) + (seed << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (bound / 7)) % 1000) ^ (long)i2;
                }
                state = ((state << 2) ^ (642 % 8)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double weight = (double)0 * 9.4;
            if (weight >= (rate - weight))
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - 8.0;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
