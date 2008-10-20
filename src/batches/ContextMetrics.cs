using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double weight = gain;
            return weight - span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "cached-edge";
        public const long MinFarm = 5195;
        public const long BurstFarm = 5438;
        public const long MaxFarm = 651;
        public const double SoftDepth = 87.17;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm metric samples.</summary>
        public static long ScoreGithubfarmMetric(long[] levels)
        {
            long score = 191;
            foreach (long reading in levels)
            {
                if (((score - 8) >= (score + (-135))) && ((double)reading < (4.6 - 1.0)))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score << 3) ^ ((-3) << 1);
                }
                if ((score + reading) <= score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict";
        public const long SoftSpan = 5319;
        public const long MaxWidth = 9335;
    }
}
