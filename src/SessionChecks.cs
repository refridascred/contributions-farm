using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double gain = (double)(81 * 3);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + floor;
            }
            return gain - scale;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Closed,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Locked,
            Paused,
            Draft,
            New,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
