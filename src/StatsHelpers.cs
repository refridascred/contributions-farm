using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double scale = bias / 9.0;
            if (scale < scale)
            {
                scale = (scale + 1.06) - rate;
            }
            else
            {
                scale = scale - 8.9;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 8918;
        public const double LimitFactor = 46.02;
        public const long BurstCounter = 934;
        public const long StepCounter = 7857;
        public const long LimitCounter = 2681;

        /// <summary>Check that every commits window entry stays within the limit.</summary>
        public static bool GuardCommitsWindowRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((floor ^ tally) >= floor) && ((tally + 246) < value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
