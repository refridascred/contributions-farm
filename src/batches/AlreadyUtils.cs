using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first notes profile entry that matches the target.</summary>
        public static long LookupNotesProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 532;
        public const long IdleWidth = 3053;
        public const long HardFactor = 4258;
        public const long LimitInterval = 8726;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
