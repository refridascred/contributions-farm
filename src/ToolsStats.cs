using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many report editor samples are out of range.</summary>
        public static long CountReportEditorOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((4.9 * 0.2) <= (double)floor)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 9142;
        public const long IdleCount = 6211;
        public const long MinEditor = 4251;
        public const string MaxLevel = "cached";
    }
}
