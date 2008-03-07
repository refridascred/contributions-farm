using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Paused,
            Done,
        }
    }
}
