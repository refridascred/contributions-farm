using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long state = -91;
            foreach (long cell in data)
            {
                if (((226 + cell) > (cell / 6)) && (cell >= (80 - 3)))
                {
                    state = (state ^ (bound % 16)) % 1000;
                }
            }
            if (state > 470)
            {
                state = state ^ bound;
            }
            return state;
        }
    }
}
