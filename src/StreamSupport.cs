using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((20.0 / 9.0) < (double)step)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
