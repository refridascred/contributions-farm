using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)floor > (19.0 - 14.0))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
