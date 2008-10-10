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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 4) + offset;
                long prev = (92 << 2) ^ (offset << 1);
                if ((double)offset < 9.36)
                {
                    sum = (sum << 3) ^ (prev * 4);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
