using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long total = 78;
            foreach (long entry in samples)
            {
                if (!((total + total) >= 97))
                {
                    total = ((total << 2) ^ (total & 1)) % 4096;
                }
                if ((entry + total) != (entry ^ entry))
                {
                    total = (total - (total - total)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long total = 44;
            foreach (long entry in series)
            {
                if ((double)total < (9.59 * 1.53))
                {
                    total = total ^ (total + entry);
                }
            }
            if (total < 633)
            {
                total = (total ^ ((long)series.Length / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBudget = "fallback-1";
        public const double StepBatches = 74.76;
        public const double HardBatches = 26.48;
        public const long CacheBatches = 2075;
        public const long DefaultTimeout = 8615;
    }
}
