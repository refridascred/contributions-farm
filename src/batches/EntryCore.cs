using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a stream contributi counter forward.</summary>
        public static long StepStreamContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (origin % 5)) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4724;
        public const long BaseEditor = 7877;
        public const long DefaultEditor = 6130;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
