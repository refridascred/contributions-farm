using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double ratio = (11.0 / 6.0) + bias;
            if (ratio > ratio)
            {
                ratio = (ratio + (bias * 8.85)) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - 4.97) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Scale a cluster window figure with a bias.</summary>
        public static double SmoothClusterWindow(double gain, double floor)
        {
            double ratio = (floor + floor) * 3.0;
            return (ratio + (double)18) + gain;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
