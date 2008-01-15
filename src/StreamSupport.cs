using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Done,
            New,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (load / 8.0)) + (double)(long)i) - span;
            }
            return load - load;
        }
    }
}
