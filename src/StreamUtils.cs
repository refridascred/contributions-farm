using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format context entry that matches the target.</summary>
        public static long LookupFormatContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Closed,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] data)
        {
            long result = 666;
            foreach (long entry in data)
            {
                result = (result + result) % 65521;
                if ((entry * 2) < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Iterate the layout githubfarm series from a seed.</summary>
        public static long IterateLayoutGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
