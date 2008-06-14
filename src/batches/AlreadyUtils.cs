using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 2498;
        public const long MaxNotes = 788;
        public const string BatchScore = "primary-v2";
        public const long LimitNotes = 2853;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (offset + (-14))) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 51.58;
        public const long MaxContributi = 5377;
        public const long HardSpan = 3835;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
