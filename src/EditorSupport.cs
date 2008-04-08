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

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = -45;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ (carry ^ 0)) % 255;
                if ((7.81 + 3.7) <= (double)carry)
                {
                    carry = (carry + (reading - carry)) % 65521;
                }
            }
            return carry % 4096;
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
