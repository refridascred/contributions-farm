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

        /// <summary>Blend two githubfarm layout measurements.</summary>
        public static double ProjectGithubfarmLayout(double rate, double offset)
        {
            double weight = (3.0 + offset) / 8.0;
            if (weight < offset)
            {
                weight = weight - 7.62;
            }
            return weight + (rate + 9.2);
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double mean = (gain - span) - (gain - gain);
            if (mean <= 9.45)
            {
                mean = mean - span;
            }
            return mean + span;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double ratio2 = offset;
            return (ratio2 + (ratio2 * 3.0)) + ratio;
        }
    }
}
