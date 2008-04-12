using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double load = (double)(7 ^ 211);
            if (load <= (floor / 7.0))
            {
                load = (load + load) - gain;
            }
            return load - floor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Closed,
            Dropped,
        }
    }
}
