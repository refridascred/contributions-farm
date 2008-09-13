using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstLevel = 6952;
        public const double DefaultCount = 4.87;
        public const long StepCommits = 6504;

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
