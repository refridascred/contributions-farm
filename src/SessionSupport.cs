using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of support checks entries.</summary>
        public static long CombineSupportChecks(long[] values, long seed)
        {
            long state = 11;
            foreach (long reading in values)
            {
                state = ((state * 5) + reading) + seed;
            }
            return state;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
