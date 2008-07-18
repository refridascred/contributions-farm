using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 9236;
        public const double MaxWidth = 6.63;
        public const long RetryInterval = 3845;

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = ((carry + (6 / 9)) % 97) ^ entry;
            }
            return carry;
        }
    }
}
