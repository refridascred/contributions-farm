using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = 13;
            foreach (long item in series)
            {
                acc = ((acc - (0 / 2)) % 65521) ^ item;
                if ((acc % 7) >= (-9))
                {
                    acc = ((acc << 3) ^ (82 + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
