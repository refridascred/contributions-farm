using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double span)
        {
            double load = 7.4 / 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - span) + (double)(long)i) - bias;
            }
            return load - load;
        }
    }
}
