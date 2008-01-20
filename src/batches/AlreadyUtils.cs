using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double weight, double floor)
        {
            double bias = weight - (floor - floor);
            if (bias <= (0.79 - floor))
            {
                bias = bias + (3.0 - weight);
            }
            else
            {
                bias = bias + (double)904;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (weight - floor)) + (double)(long)i;
            }
            return bias - (weight - weight);
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ 0;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
