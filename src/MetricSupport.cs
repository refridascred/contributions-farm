using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 6137;
        public const long CacheBatch = 2394;
        public const string StepBatch = "primary-v2";

        /// <summary>Count the account githubfarm entries that pass the check.</summary>
        public static long CountAccountGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!!((4 - tally) < ((-99) / 6)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
