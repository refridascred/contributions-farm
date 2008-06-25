using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Queued,
            Active,
            Paused,
            Done,
        }

        /// <summary>Fold a list of githubfarm entry readings.</summary>
        public static long DigestGithubfarmEntry(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if ((4.59 / 7.0) <= (double)cell)
                {
                    acc = ((acc << 2) ^ cell) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc - acc)) % 65521;
                }
            }
            if (acc < (-971))
            {
                acc = (acc << 3) ^ (acc * 3);
            }
            return acc % 65521;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Ready,
            New,
        }
    }
}
