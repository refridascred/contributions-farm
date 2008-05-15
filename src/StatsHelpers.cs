using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > bound)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + ((long)i << 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
