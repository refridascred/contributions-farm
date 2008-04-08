using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double gain = 3.0;
            if (gain < bias)
            {
                gain = (gain + (bias / 3.0)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (bias - 3.4);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Draft,
            Ready,
            New,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = ((mix << 2) ^ step) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowInterval = 3631;
        public const long WindowChecks = 9757;
        public const long CacheRatio = 3234;
        public const long BurstScore = 673;
    }
}
