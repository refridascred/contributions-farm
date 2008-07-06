using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long MatchClusterLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up queue editor samples.</summary>
        public static long CompareQueueEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
