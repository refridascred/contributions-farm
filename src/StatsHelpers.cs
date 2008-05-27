using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "alpha";
        public const double StepBudget = 28.01;
        public const double MinSupport = 63.4;

        /// <summary>Find the first format filter entry that matches the target.</summary>
        public static long SeekFormatFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream schema figure with a bias.</summary>
        public static double AdjustStreamSchema(double scale, double floor)
        {
            double weight = 4.1 * 1.0;
            if (weight > floor)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight + (scale * 6.59);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + (7.0 / 4.0);
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long FoldCommitsPayload(long[] values)
        {
            long mix = 54;
            foreach (long datum in values)
            {
                if ((double)mix > (9.8 + 2.6))
                {
                    mix = ((mix << 3) ^ (long)values.Length) + datum;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Paused,
            Draft,
            Idle,
            Queued,
        }
    }
}
