using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Dropped,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry editor entries that pass the check.</summary>
        public static long CountEntryEditorHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((5.1 - 5.48) < (double)offset) || ((entry << 1) > (count << 2))) || ((offset << 2) > (entry * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSize = 67.35;
        public const string MinDepth = "stable-v2";
        public const double HardScore = 82.68;
        public const double WindowRatio = 29.43;
    }
}
