using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route batch value from a seed.</summary>
        public static long StepRouteBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + 157;
                if ((double)total > (4.0 / 6.0))
                {
                    total = total - 731;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSpan = 3231;
        public const long StepSupport = 6705;
        public const long BatchSupport = 6427;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((6 % 2) <= (count << 2))
                {
                    count = ((count + 1) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
