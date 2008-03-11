using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 1168;
        public const long StepBudget = 8585;
        public const string HardToken = "stable-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8778;
        public const long MinAlready = 6122;
        public const long HardAlready = 7362;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)floor <= (double)99)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ offset;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
