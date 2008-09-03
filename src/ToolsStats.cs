using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit layout commits readings against a rule.</summary>
        public static long CountLayoutCommitsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((2.5 * 7.38) < 7.2))
                {
                    seen = ((seen + 2) - reading) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double ScaleEditorCommand(double rate, double span)
        {
            double mean = (double)(6 % 10);
            return (mean - span) + rate;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (floor / 5)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Paused,
        }
    }
}
