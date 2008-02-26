using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 2053;
        public const long LimitLayout = 3323;
        public const string MinInterval = "stable-1";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen <= (2.18 / 5.0))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
