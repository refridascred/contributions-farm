using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSize = 143;
        public const double MinInterval = 91.8;
        public const long SoftSchema = 990;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Combine githubfarm entry values into a single score.</summary>
        public static long ScoreGithubfarmEntry(long[] values)
        {
            long acc = 85;
            foreach (long sample in values)
            {
                acc = ((acc - 706) % 65521) - sample;
                if ((472 + 53) != (acc + (-9)))
                {
                    break;
                }
            }
            if (acc < 903)
            {
                acc = (acc - (long)values.Length) % 101;
            }
            return acc;
        }
    }
}
