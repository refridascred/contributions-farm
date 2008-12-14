using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit context editor readings against a rule.</summary>
        public static long CountContextEditorGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((59 % 12) < (seed & 127))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }
    }
}
