using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cluster command readings against a rule.</summary>
        public static long TallyClusterCommandGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (475 <= (matches + matches))
                {
                    matches = ((matches + 3) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            New,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Iterate the schema metrics series from a seed.</summary>
        public static long SeriesSchemaMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ matches) < (reading - 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats context measurements.</summary>
        public static double BlendStatsContext(double weight, double bias)
        {
            double drift = bias;
            if (drift <= weight)
            {
                drift = drift + (double)(-80);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
