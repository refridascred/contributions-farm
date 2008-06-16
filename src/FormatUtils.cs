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

        /// <summary>Fold a list of session queue readings.</summary>
        public static long WeighSessionQueue(long[] levels)
        {
            long anchor = 996;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (576 + anchor)) + value;
            }
            if (anchor < 271)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
