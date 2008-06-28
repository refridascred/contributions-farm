using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc / 6);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((matches >> 2) == (matches - limit)) || (value > (value + limit))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 6643;
        public const long BaseWidth = 7968;
        public const string HardLevel = "staging";
        public const long DefaultInterval = 7515;
        public const long MaxWidth = 9997;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(origin > (sample / 6)) && ((sample << 1) >= origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
