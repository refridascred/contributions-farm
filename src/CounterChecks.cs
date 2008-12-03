using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "cached-edge";
        public const long IdleFormat = 5696;
        public const long MinSpan = 6020;
    }
}
