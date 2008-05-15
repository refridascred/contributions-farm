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

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long seed)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc - (seed >> 4)) % 4096) - (long)i) ^ item;
                }
                acc = acc + (seed % 3);
            }
            if (acc > 20)
            {
                acc = (acc + (8 & 3)) % 101;
            }
            return acc % 1000;
        }
    }
}
