using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
