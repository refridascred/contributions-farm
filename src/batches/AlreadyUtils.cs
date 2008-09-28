using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every format route entry stays within the limit.</summary>
        public static bool CheckFormatRouteBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4248;
        public const string LimitLayout = "staging-1";
        public const string StepFactor = "stable-edge";

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (seed <= (seed % 16))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Paused,
            Locked,
        }
    }
}
