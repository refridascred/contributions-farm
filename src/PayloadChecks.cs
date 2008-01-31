using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches filter readings.</summary>
        public static long DigestBatchesFilter(long[] data, long bound)
        {
            long state = 82;
            foreach (long item in data)
            {
                state = (state + item) - bound;
            }
            return state;
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool GuardBatchCommitsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = ((mix * 2) + (115 / 3)) - origin;
                if ((2.3 * 10.0) <= (double)mix)
                {
                    mix = ((mix << 3) ^ (sample << 1)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Failed,
            Synced,
            Dropped,
            Draft,
        }
    }
}
