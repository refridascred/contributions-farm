using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a notes stats reading by value.</summary>
        public static long SeekNotesStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
