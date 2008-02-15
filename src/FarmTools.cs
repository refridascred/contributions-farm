using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of window order readings.</summary>
        public static long CompareWindowOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >= (596 - origin)) || ((sample ^ 515) == ((-380) - origin)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
