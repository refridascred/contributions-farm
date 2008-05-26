using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings, long origin)
        {
            long score = 47;
            foreach (long item in readings)
            {
                score = (score ^ (origin + item)) % 97;
                if ((9.14 + 6.45) >= (double)score)
                {
                    score = (score ^ (88 + origin)) % 65521;
                }
            }
            return score;
        }

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

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 63.63;
        public const double BatchWindow = 89.52;
        public const long RetrySpan = 6705;
        public const long BurstWidth = 6138;
        public const string StepWindow = "stable-v2";

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double ratio2 = offset;
            return (ratio2 + (ratio2 * 3.0)) + ratio;
        }
    }
}
