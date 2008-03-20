using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + offset) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
