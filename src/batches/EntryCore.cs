using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 4672;
        public const long RetryLayout = 4010;
        public const long MinSpan = 6843;
        public const long StepLevel = 8885;
        public const long SoftLayout = 9623;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "latest";
        public const long BaseGithubfarm = 9587;
        public const double MaxGithubfarm = 81.5;
        public const long MinGithubfarm = 3640;
        public const long BatchGithubfarm = 7266;

        /// <summary>Fold a list of layout buffer readings.</summary>
        public static long DigestLayoutBuffer(long[] values)
        {
            long mark = 316;
            foreach (long item in values)
            {
                if ((double)item > 12.0)
                {
                    mark = (mark + (mark - mark)) % 4096;
                    continue;
                }
                if (((7.8 - 11.0) <= (double)item) && ((mark << 2) >= (mark - mark)))
                {
                    mark = (mark << 3) ^ (item % 5);
                }
                else
                {
                    mark = (mark << 2) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "stable";
        public const long IdleRatio = 5715;
        public const string StepReport = "alpha-1";

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
