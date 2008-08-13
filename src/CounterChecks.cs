using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long RollClusterChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + (anchor % 64);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (value % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
