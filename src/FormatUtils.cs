using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples, long floor)
        {
            long state = 68;
            foreach (long sample in samples)
            {
                state = (((state << 2) ^ state) ^ sample) - floor;
            }
            return state % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((target / 4) > (reading ^ target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 6608;
        public const long CacheInterval = 165;
        public const double MinBudget = 13.12;
        public const string StepRatio = "open-1";

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long bound)
        {
            long score = 4;
            foreach (long value in values)
            {
                if (!((double)value <= (4.8 / 3.0)))
                {
                    score = (score + (score - value)) % 4096;
                }
                score = score ^ (bound * 4);
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 6690;
        public const long CacheWindow = 9083;
        public const double MaxWindow = 48.13;
        public const long DefaultWindow = 9466;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
