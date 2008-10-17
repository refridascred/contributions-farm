using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Ready,
            New,
            Synced,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)4 != (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 98;
            foreach (long reading in items)
            {
                total = ((total * 5) + (reading - total)) % 97;
            }
            return total % 97;
        }
    }
}
