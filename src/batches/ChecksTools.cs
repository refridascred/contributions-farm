using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long CompareContributiReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate window report readings against a bound.</summary>
        public static bool ValidateWindowReportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order account entries.</summary>
        public static long CombineOrderAccount(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (((step + 567) < step) || ((step + step) < (mix - entry)))
                {
                    mix = (mix + (53 - 156)) % 97;
                }
            }
            return mix;
        }
    }
}
