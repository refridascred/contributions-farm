using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ (73 + 813)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
