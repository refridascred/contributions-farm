using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 13.15;
        public const long IdleRatio = 9212;
        public const long IdleScore = 8846;
        public const long BurstBatch = 8686;

        /// <summary>Audit context graph readings against a rule.</summary>
        public static long AuditContextGraphOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= limit)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double drift = (double)709 / 4.0;
            if (drift < (9.8 + floor))
            {
                drift = (drift + floor) - rate;
            }
            else
            {
                drift = drift - (double)1;
            }
            return drift - 0.43;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result - (9 ^ result)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
