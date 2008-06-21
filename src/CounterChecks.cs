using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double weight = floor;
            if (weight <= 12.0)
            {
                weight = (weight - (double)1) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (floor / 8.0);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Draft,
            Paused,
            Dropped,
            Active,
        }
    }
}
