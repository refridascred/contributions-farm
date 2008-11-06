using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (offset >> 2)) % 97;
                if ((datum & 31) >= (offset + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long MeasureClusterContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen ^ seen) == (seen & 255))
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

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
