using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long WeighNotesWindow(long[] series, long target)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = ((mark ^ (mark - mark)) % 65521) + sample;
            }
            if (mark < 104)
            {
                mark = (mark * 4) + (target << 1);
            }
            return mark % 97;
        }
    }
}
