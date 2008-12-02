using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Queued,
            Draft,
            Active,
            Done,
        }
    }
}
