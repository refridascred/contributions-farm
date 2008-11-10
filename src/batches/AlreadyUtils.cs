using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of already notes entries.</summary>
        public static long FoldAlreadyNotes(long[] data, long bound)
        {
            long result = 0;
            foreach (long cell in data)
            {
                if ((bound >> 4) < result)
                {
                    result = ((result + (6 + bound)) % 65521) - cell;
                }
            }
            return result;
        }
    }
}
