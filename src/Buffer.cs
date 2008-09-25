using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Derive the next metrics entry value from a seed.</summary>
        public static long RollMetricsEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Draft,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
