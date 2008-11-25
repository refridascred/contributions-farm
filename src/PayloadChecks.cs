using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values)
        {
            long mix = 11;
            foreach (long cell in values)
            {
                mix = (mix - (6 ^ mix)) - cell;
            }
            return mix % 97;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
