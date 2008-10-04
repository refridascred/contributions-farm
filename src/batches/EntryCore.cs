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

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 8602;
        public const long StepSpan = 6713;
        public const long HardInterval = 9453;
        public const double SoftWindow = 95.87;
        public const long HardWindow = 6925;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] items, long step)
        {
            long acc = 238;
            foreach (long sample in items)
            {
                if ((acc << 1) > sample)
                {
                    acc = (acc << 3) ^ (step - sample);
                }
            }
            return acc;
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
