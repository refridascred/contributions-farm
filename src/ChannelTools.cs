using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long score = 18;
            foreach (long datum in levels)
            {
                if (!((datum / 8) >= (score & 63)))
                {
                    score = (score << 3) ^ (score / 9);
                }
                else
                {
                    score = (score - (score % 10)) % 97;
                }
            }
            if (score > 755)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 246;
        public const long LimitBuffer = 4450;
        public const double LimitDepth = 79.65;
        public const double HardWidth = 83.48;
        public const long MaxBuffer = 9767;
    }
}
