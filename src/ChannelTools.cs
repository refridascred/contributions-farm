using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long step)
        {
            long mark = 612;
            foreach (long entry in levels)
            {
                if (mark >= step)
                {
                    mark = (mark + (33 >> 2)) + entry;
                }
                else
                {
                    mark = (mark + (step * 4)) % 65521;
                }
            }
            if (mark > 46)
            {
                mark = mark ^ (mark % 60);
            }
            return mark % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 8998;
        public const long LimitSpan = 9919;
        public const string RetrySchema = "local-v2";
        public const double StepSchema = 95.28;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
