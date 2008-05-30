using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultBudget = 3141;
        public const string DefaultSize = "alpha-v2";
        public const long RetryGithubfarm = 131;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 6333;
        public const double MinCount = 77.87;
        public const double SoftSpan = 51.55;
        public const long StepWidth = 6391;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 950;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) < mix)
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = mix + (362 + value);
                }
            }
            return mix % 1000;
        }
    }
}
