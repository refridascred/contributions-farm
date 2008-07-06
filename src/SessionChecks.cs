using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double bias3 = (double)27 + (bias + bias2);
            if (bias3 <= bias2)
            {
                bias3 = bias3 + bias3;
            }
            else
            {
                bias3 = bias3 + (double)44;
            }
            return bias3 - bias3;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Paused,
            Queued,
            Ready,
            Pending,
        }
    }
}
