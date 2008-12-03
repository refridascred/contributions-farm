using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double weight = offset;
            return (weight - 5.6) + scale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches % 97) <= matches)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
