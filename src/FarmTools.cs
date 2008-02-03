using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((2.1 + 5.21) >= (double)seen)
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
