using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples)
        {
            long anchor = 708;
            foreach (long value in samples)
            {
                if ((3 - anchor) < value)
                {
                    anchor = ((anchor * 3) + (anchor % 8)) % 101;
                }
                if ((double)value <= (4.0 - 4.8))
                {
                    break;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor + (94 & 31);
            }
            return anchor;
        }

        /// <summary>Find the first cache support entry that matches the target.</summary>
        public static long LocateCacheSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Queued,
            Failed,
            Locked,
            New,
        }
    }
}
