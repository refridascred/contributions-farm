using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count metric batch pairs that satisfy a relation.</summary>
        public static long OverlapMetricBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
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
