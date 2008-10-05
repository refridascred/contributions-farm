using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Queued,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels, long target)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                result = (result + result) % 1000;
                result = result + (target + cell);
                result = ((result << 2) ^ ((-8) & 7)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit >> 1) < (count << 1))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
