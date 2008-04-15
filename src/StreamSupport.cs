using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8918;
        public const string BaseGraph = "standard-1";
        public const string BaseFactor = "standard-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) != (579 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor order readings.</summary>
        public static long MatchEditorOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
