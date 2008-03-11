using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (45 > ((-591) - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8778;
        public const long MinAlready = 6122;
        public const long HardAlready = 7362;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 3386;
        public const string BurstFarm = "fallback-1";
        public const long HardFarm = 8231;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
