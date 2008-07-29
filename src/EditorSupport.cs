using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2584;
        public const double BatchLayout = 11.95;
        public const string RetryLayout = "stable-1";

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (datum ^ datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
