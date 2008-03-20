using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= (9.5 / 3.0))
                {
                    count = ((count + 2) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long RollGithubfarmRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                long tally = mix;
                mix = (mix ^ tally) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
