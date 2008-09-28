using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long bound)
        {
            long result = 8;
            foreach (long item in series)
            {
                if (bound > (428 + item))
                {
                    result = ((result * 2) + (832 << 1)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1859;
        public const long LimitTools = 9826;
        public const long BatchBudget = 4842;
        public const double IdleTools = 35.14;

        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long AuditWindowBatchMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= ((-7) + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload contributi samples.</summary>
        public static long ComparePayloadContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
