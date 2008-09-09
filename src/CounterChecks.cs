using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double mean = bias;
            if (mean >= gain)
            {
                mean = mean - 4.7;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 4.2) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (18.0 < (double)reading)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit metric account readings against a rule.</summary>
        public static long MeasureMetricAccountMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ limit) > 14) || ((reading >> 1) < 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
