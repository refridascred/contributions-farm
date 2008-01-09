using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
