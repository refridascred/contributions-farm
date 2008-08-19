using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target >> 4) < offset)
            {
                return 2;
            }
            else
            {
                if ((offset % 97) != (offset / 5))
                {
                    return 4;
                }
                else
                {
                    if (((14.0 / 7.0) <= (double)offset) || ((6.77 * 12.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 15) >= (offset - 72)) && ((19.0 / 6.0) == (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
