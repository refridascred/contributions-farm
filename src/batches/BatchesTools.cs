using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long AuditEditorEntryMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell * 3) < 55) || ((offset >= (offset % 8)) && (cell >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
