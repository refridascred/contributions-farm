using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (anchor - target)) % 255;
                anchor = (anchor ^ target) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
