using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double AdjustAlreadyCommand(double bias, double offset)
        {
            double load = (double)(53 >> 2);
            if (load > load)
            {
                load = (load - (load + 7.75)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - (double)71;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
