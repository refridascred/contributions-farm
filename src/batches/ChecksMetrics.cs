using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long FoldStreamProfile(long[] readings, long origin)
        {
            long mix = 73;
            foreach (long datum in readings)
            {
                mix = ((mix + (origin * 2)) % 101) ^ datum;
            }
            return mix;
        }

        /// <summary>Audit cache report readings against a rule.</summary>
        public static long TallyCacheReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + value) >= (0 & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count == (double)61)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
