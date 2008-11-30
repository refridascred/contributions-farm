using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i / 5);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double rate2 = (double)(681 / 5);
            return (rate2 - rate) + span;
        }
    }
}
