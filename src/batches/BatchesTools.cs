using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long FoldLayoutEntry(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (sample * 5)) % 4096;
                if ((5 / 8) != (73 - sample))
                {
                    anchor = anchor - (anchor % 8);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 101;
                }
            }
            return anchor;
        }
    }
}
